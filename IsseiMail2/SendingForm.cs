using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsseiMail2
{
    public partial class SendingForm : Form
    {
        private readonly Task task;
        private readonly Action onCancel;

        internal Exception Error { get; private set; }

        public SendingForm(Task task, Action onCancel)
        {
            this.task = task;
            this.onCancel = onCancel;

            InitializeComponent();

            var subTask = WaitForTask(task);
        }

        private async Task WaitForTask(Task task)
        {
            try
            {
                await task;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Error = ex;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void SendingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            onCancel();
        }
    }
}
