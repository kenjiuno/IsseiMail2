namespace IsseiMail2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senderText = new System.Windows.Forms.TextBox();
            this.editSender = new System.Windows.Forms.Button();
            this.toText = new System.Windows.Forms.TextBox();
            this.editTo = new System.Windows.Forms.Button();
            this.bccText = new System.Windows.Forms.TextBox();
            this.editBcc = new System.Windows.Forms.Button();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.table);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(804, 523);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(804, 562);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Yu Gothic UI", 14F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(127, 39);
            this.toolStrip1.TabIndex = 0;
            // 
            // table
            // 
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.label2, 0, 1);
            this.table.Controls.Add(this.label3, 0, 2);
            this.table.Controls.Add(this.label4, 0, 4);
            this.table.Controls.Add(this.senderText, 1, 0);
            this.table.Controls.Add(this.editSender, 2, 0);
            this.table.Controls.Add(this.toText, 1, 1);
            this.table.Controls.Add(this.editTo, 2, 1);
            this.table.Controls.Add(this.bccText, 1, 2);
            this.table.Controls.Add(this.editBcc, 2, 2);
            this.table.Controls.Add(this.bodyText, 0, 5);
            this.table.Controls.Add(this.label5, 0, 3);
            this.table.Controls.Add(this.subjectText, 1, 3);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(804, 523);
            this.table.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "差出人";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "宛先";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bcc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "本文";
            // 
            // senderText
            // 
            this.senderText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.senderText.Location = new System.Drawing.Point(105, 4);
            this.senderText.Name = "senderText";
            this.senderText.ReadOnly = true;
            this.senderText.Size = new System.Drawing.Size(612, 34);
            this.senderText.TabIndex = 1;
            // 
            // editSender
            // 
            this.editSender.AutoSize = true;
            this.editSender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editSender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editSender.Location = new System.Drawing.Point(723, 3);
            this.editSender.Name = "editSender";
            this.editSender.Size = new System.Drawing.Size(78, 37);
            this.editSender.TabIndex = 2;
            this.editSender.Text = "編集";
            this.editSender.UseVisualStyleBackColor = true;
            this.editSender.Click += new System.EventHandler(this.editSender_Click);
            // 
            // toText
            // 
            this.toText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toText.Location = new System.Drawing.Point(105, 47);
            this.toText.Name = "toText";
            this.toText.ReadOnly = true;
            this.toText.Size = new System.Drawing.Size(612, 34);
            this.toText.TabIndex = 4;
            // 
            // editTo
            // 
            this.editTo.AutoSize = true;
            this.editTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editTo.Location = new System.Drawing.Point(723, 46);
            this.editTo.Name = "editTo";
            this.editTo.Size = new System.Drawing.Size(78, 37);
            this.editTo.TabIndex = 5;
            this.editTo.Text = "編集";
            this.editTo.UseVisualStyleBackColor = true;
            this.editTo.Click += new System.EventHandler(this.editTo_Click);
            // 
            // bccText
            // 
            this.bccText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bccText.Location = new System.Drawing.Point(105, 90);
            this.bccText.Name = "bccText";
            this.bccText.ReadOnly = true;
            this.bccText.Size = new System.Drawing.Size(612, 34);
            this.bccText.TabIndex = 7;
            // 
            // editBcc
            // 
            this.editBcc.AutoSize = true;
            this.editBcc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBcc.Location = new System.Drawing.Point(723, 89);
            this.editBcc.Name = "editBcc";
            this.editBcc.Size = new System.Drawing.Size(78, 37);
            this.editBcc.TabIndex = 8;
            this.editBcc.Text = "編集";
            this.editBcc.UseVisualStyleBackColor = true;
            this.editBcc.Click += new System.EventHandler(this.editBcc_Click);
            // 
            // bodyText
            // 
            this.table.SetColumnSpan(this.bodyText, 2);
            this.bodyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyText.Location = new System.Drawing.Point(3, 209);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bodyText.Size = new System.Drawing.Size(714, 311);
            this.bodyText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "件名";
            // 
            // subjectText
            // 
            this.subjectText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectText.Location = new System.Drawing.Point(105, 132);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(612, 34);
            this.subjectText.TabIndex = 10;
            // 
            // sendBtn
            // 
            this.sendBtn.Image = global::IsseiMail2.Properties.Resources.SendEmail_32x;
            this.sendBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(115, 36);
            this.sendBtn.Text = "送信する";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 562);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "一斉メール";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senderText;
        private System.Windows.Forms.Button editSender;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Button editTo;
        private System.Windows.Forms.TextBox bccText;
        private System.Windows.Forms.Button editBcc;
        private System.Windows.Forms.TextBox bodyText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.ToolStripButton sendBtn;
    }
}

