using System.Windows.Forms;

namespace PhishingReportAddin
{
    partial class PhishingReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhishingReportForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spamCheckBox = new System.Windows.Forms.CheckBox();
            this.phishingCheckBox = new System.Windows.Forms.CheckBox();
            this.notSureCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.dontReportButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.separatorPanel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Message";
            this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thank you for reporting this message.\nThis message will be deleted from the original mailbox and sent to the Security Department for review.";
            this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // spamCheckBox
            // 
            this.spamCheckBox.AutoSize = true;
            this.spamCheckBox.Location = new System.Drawing.Point(39, 127);
            this.spamCheckBox.Name = "spamCheckBox";
            this.spamCheckBox.Size = new System.Drawing.Size(161, 20);
            this.spamCheckBox.TabIndex = 3;
            this.spamCheckBox.Text = "Received spam email";
            this.spamCheckBox.UseVisualStyleBackColor = true;
            this.spamCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // phishingCheckBox
            // 
            this.phishingCheckBox.AutoSize = true;
            this.phishingCheckBox.Location = new System.Drawing.Point(39, 153);
            this.phishingCheckBox.Name = "phishingCheckBox";
            this.phishingCheckBox.Size = new System.Drawing.Size(188, 20);
            this.phishingCheckBox.TabIndex = 4;
            this.phishingCheckBox.Text = "Received a phishing email";
            this.phishingCheckBox.UseVisualStyleBackColor = true;
            this.phishingCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // notSureCheckBox
            // 
            this.notSureCheckBox.AutoSize = true;
            this.notSureCheckBox.Location = new System.Drawing.Point(39, 179);
            this.notSureCheckBox.Name = "notSureCheckBox";
            this.notSureCheckBox.Size = new System.Drawing.Size(240, 20);
            this.notSureCheckBox.TabIndex = 5;
            this.notSureCheckBox.Text = "I'm not sure this is a legitimate email";
            this.notSureCheckBox.UseVisualStyleBackColor = true;
            this.notSureCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Provide additional information, if any:";
            this.label3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalInfoTextBox.Location = new System.Drawing.Point(39, 240);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(792, 94);
            this.additionalInfoTextBox.TabIndex = 7;
            this.additionalInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.additionalInfoTextBox.Text = "Type here";
            this.additionalInfoTextBox.ForeColor = System.Drawing.Color.Gray;
            this.additionalInfoTextBox.Enter += new System.EventHandler(this.additionalInfoTextBox_Enter);
            this.additionalInfoTextBox.Leave += new System.EventHandler(this.additionalInfoTextBox_Leave);
            // 
            // dontReportButton
            // 
            this.dontReportButton.Location = new System.Drawing.Point(718, 348);
            this.dontReportButton.Name = "dontReportButton";
            this.dontReportButton.Size = new System.Drawing.Size(113, 37);
            this.dontReportButton.TabIndex = 9;
            this.dontReportButton.Text = "Don't Report";
            this.dontReportButton.UseVisualStyleBackColor = true;
            this.dontReportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.dontReportButton.Click += new System.EventHandler(this.dontReportButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(588, 348);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(113, 37);
            this.reportButton.TabIndex = 10;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // separatorPanel
            // 
            this.separatorPanel.BackColor = System.Drawing.Color.Gray;
            this.separatorPanel.Location = new System.Drawing.Point(39, 112);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(792, 1);
            this.separatorPanel.TabIndex = 8;
            this.separatorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // separatorPanel1
            // 
            this.separatorPanel1.BackColor = System.Drawing.Color.Gray;
            this.separatorPanel1.Location = new System.Drawing.Point(39, 208);
            this.separatorPanel1.Name = "separatorPanel1";
            this.separatorPanel1.Size = new System.Drawing.Size(792, 1);
            this.separatorPanel1.TabIndex = 9;
            this.separatorPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // PhishingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 397);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.dontReportButton);
            this.Controls.Add(this.additionalInfoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notSureCheckBox);
            this.Controls.Add(this.phishingCheckBox);
            this.Controls.Add(this.spamCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.separatorPanel);
            this.Controls.Add(this.separatorPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhishingReportForm";
            this.Text = "Phishing Report";
            this.Load += new System.EventHandler(this.PhishingReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox spamCheckBox;
        public System.Windows.Forms.CheckBox phishingCheckBox;
        public System.Windows.Forms.CheckBox notSureCheckBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox additionalInfoTextBox;
        public System.Windows.Forms.Button dontReportButton;
        public System.Windows.Forms.Button reportButton;
        public System.Windows.Forms.Panel separatorPanel;
        public System.Windows.Forms.Panel separatorPanel1;
    }
}
