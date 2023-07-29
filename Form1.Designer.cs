
namespace Whatsapp_Automation__app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cntctNmbr = new System.Windows.Forms.TextBox();
            this.sndBtn = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MsgField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Number ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message ";
            // 
            // cntctNmbr
            // 
            this.cntctNmbr.Location = new System.Drawing.Point(187, 54);
            this.cntctNmbr.Name = "cntctNmbr";
            this.cntctNmbr.Size = new System.Drawing.Size(315, 20);
            this.cntctNmbr.TabIndex = 2;
            // 
            // sndBtn
            // 
            this.sndBtn.Location = new System.Drawing.Point(551, 301);
            this.sndBtn.Name = "sndBtn";
            this.sndBtn.Size = new System.Drawing.Size(85, 38);
            this.sndBtn.TabIndex = 4;
            this.sndBtn.Text = "Send";
            this.sndBtn.UseVisualStyleBackColor = true;
            this.sndBtn.Click += new System.EventHandler(this.snd_Button);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkColor = System.Drawing.Color.Black;
            this.linkLabel.Location = new System.Drawing.Point(184, 236);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(63, 13);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Attach Files";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.attachFiles);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MsgField
            // 
            this.MsgField.Location = new System.Drawing.Point(187, 151);
            this.MsgField.Name = "MsgField";
            this.MsgField.Size = new System.Drawing.Size(317, 20);
            this.MsgField.TabIndex = 6;
            this.MsgField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MsgField);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.sndBtn);
            this.Controls.Add(this.cntctNmbr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cntctNmbr;
        private System.Windows.Forms.Button sndBtn;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox MsgField;
    }
}

