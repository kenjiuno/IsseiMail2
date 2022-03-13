using Azure.Core;
using Azure.Identity;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IsseiMail2.Utils
{
    internal class SendOutlook
    {
        private static readonly string TOKEN_CACHE_NAME = "IsseiMail2";
        private static readonly string clientId = "1aefe3ae-7fdd-4cde-ad85-52c6d16f28a6";

        public async Task Send(string sender, string[] to, string[] bcc, string subject, string body, string authFile,
            CancellationToken cancellationToken)
        {
            // https://docs.microsoft.com/ja-jp/graph/sdks/create-client?tabs=CS
            var scopes = new[] { "User.Read", "Mail.Send", };

            // Multi-tenant apps can use "common",
            // single-tenant apps must use the tenant ID from the Azure portal
            var tenantId = "common";

            // Value from app registration

            // using Azure.Identity;
            var options = new InteractiveBrowserCredentialOptions
            {
                TenantId = tenantId,
                ClientId = clientId,
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                // MUST be http://localhost or http://localhost:PORT
                // See https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki/System-Browser-on-.Net-Core
                RedirectUri = new Uri("http://localhost"),
                LoginHint = sender,
                TokenCachePersistenceOptions = new TokenCachePersistenceOptions
                {
                    Name = TOKEN_CACHE_NAME
                },
            };

            // https://docs.microsoft.com/dotnet/api/azure.identity.interactivebrowsercredential
            InteractiveBrowserCredential credential;
            AuthenticationRecord authRecord;

            // https://docs.microsoft.com/en-us/dotnet/api/azure.identity.tokencachepersistenceoptions?view=azure-dotnet
            // Check if an AuthenticationRecord exists on disk.
            // If it does not exist, get one and serialize it to disk.
            // If it does exist, load it from disk and deserialize it.
            if (!System.IO.File.Exists(authFile))
            {
                // Construct a credential with TokenCachePersistenceOptions specified to ensure that the token cache is persisted to disk.
                // We can also optionally specify a name for the cache to avoid having it cleared by other applications.
                credential = new InteractiveBrowserCredential(options);

                // Call AuthenticateAsync to fetch a new AuthenticationRecord.
                authRecord = await credential.AuthenticateAsync(
                    new TokenRequestContext(scopes, null, null, tenantId),
                    cancellationToken
                );

                // Serialize the AuthenticationRecord to disk so that it can be re-used across executions of this initialization code.
                using (var authRecordStream = new FileStream(authFile, FileMode.Create, FileAccess.Write))
                {
                    await authRecord.SerializeAsync(authRecordStream);
                }
            }
            else
            {
                // Load the previously serialized AuthenticationRecord from disk and deserialize it.
                using (var authRecordStream = new FileStream(authFile, FileMode.Open, FileAccess.Read))
                {
                    authRecord = await AuthenticationRecord.DeserializeAsync(authRecordStream);

                    // Construct a new client with our TokenCachePersistenceOptions with the addition of the AuthenticationRecord property.
                    // This tells the credential to use the same token cache in addition to which account to try and fetch from cache when GetToken is called.
                    options.AuthenticationRecord = authRecord;
                    credential = new InteractiveBrowserCredential(options);

                    await credential.AuthenticateAsync(
                        new TokenRequestContext(scopes, null, null, tenantId),
                        cancellationToken
                    );
                }
            }

            var graphClient = new GraphServiceClient(credential, scopes);

            var message = new Message
            {
                Subject = subject,
                Body = new ItemBody
                {
                    ContentType = BodyType.Text,
                    Content = body
                },

                ToRecipients = to.Select(
                    one => new Recipient
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = one,
                        }
                    }
                )
                    .ToArray(),

                BccRecipients = bcc.Select(
                    one => new Recipient
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = one,
                        }
                    }
                )
                    .ToArray(),
            };

            var saveToSentItems = true;

            await graphClient.Me
                .SendMail(message, saveToSentItems)
                .Request()
                .PostAsync(cancellationToken);
        }
    }
}
