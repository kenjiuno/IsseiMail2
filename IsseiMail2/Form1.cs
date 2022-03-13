using IsseiMail2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsseiMail2
{
    public partial class Form1 : Form
    {
        public string SetteiDir { get; }

        public Form1()
        {
            InitializeComponent();

            SetteiDir = Path.Combine(Application.StartupPath, "Settei");
            Directory.CreateDirectory(SetteiDir);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <see cref="https://docs.microsoft.com/ja-jp/previous-versions/office/office-365-api/api/version-2.0/use-outlook-rest-api"/>
        /// <see cref="https://portal.azure.com/#blade/Microsoft_AAD_RegisteredApps/ApplicationMenuBlade/Overview/appId/1aefe3ae-7fdd-4cde-ad85-52c6d16f28a6/objectId/b665d7c0-3a21-46a2-8fae-3a3229f558eb/isMSAApp//defaultBlade/Overview/appSignInAudience/AzureADandPersonalMicrosoftAccount/servicePrincipalCreated/true"/>
        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "本当に送信しますか?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                return;
            }

            var cancellationTokenSource = new CancellationTokenSource();
            var task = new SendOutlook().Send(
                senderText.Text,
                LoadTextArray("To.txt"),
                LoadTextArray("Bcc.txt"),
                subjectText.Text,
                bodyText.Text,
                Path.Combine(SetteiDir, "Auth.bin"),
                cancellationTokenSource.Token
            );
            using (var form = new SendingForm(task, () => cancellationTokenSource.Cancel()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LogResult("メールを送信しました。");
                    MessageBox.Show("送信しました。");
                }
                else
                {
                    LogResult("メールの送信に失敗しました。\n\n" + form.Error);
                    MessageBox.Show(this, "メールの送信に失敗しました。\n\n" + form.Error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LogResult(string message)
        {
            File.WriteAllText(
                Path.Combine(SetteiDir, $"送信内容 {DateTime.Now:yyyy MM dd HH mm ss}.txt"),
                ""
                + message + "\r\n"
                + "\r\n"
                + "差出人: " + senderText.Text + "\r\n"
                + "宛先: " + toText.Text + "\r\n"
                + "Bcc: " + bccText.Text + "\r\n"
                + "件名: " + subjectText.Text + "\r\n"
                + "本文:\r\n"
                + bodyText.Text + "\r\n"
            );
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            senderText.Text = LoadText("Sender.txt");
            toText.Text = LoadText("To.txt");
            bccText.Text = LoadText("Bcc.txt");
        }

        private string LoadText(string name, string separator = ", ")
        {
            return string.Join(separator, LoadTextArray(name));
        }

        private string[] LoadTextArray(string name)
        {
            var path = Path.Combine(SetteiDir, name);
            return File.Exists(path)
                ? File.ReadAllLines(path)
                    .Select(it => it.Trim())
                    .Where(it => !string.IsNullOrEmpty(it))
                    .ToArray()
                : new string[0];
        }

        private void Notepad(string name)
        {
            var path = Path.Combine(SetteiDir, name);
            File.AppendAllText(path, "");
            Process.Start("notepad.exe", "\"" + path + "\"");
        }

        private void editSender_Click(object sender, EventArgs e)
        {
            Notepad("Sender.txt");
        }

        private void editTo_Click(object sender, EventArgs e)
        {
            Notepad("To.txt");

        }

        private void editBcc_Click(object sender, EventArgs e)
        {
            Notepad("Bcc.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " " + Application.ProductVersion;
        }
    }
}
