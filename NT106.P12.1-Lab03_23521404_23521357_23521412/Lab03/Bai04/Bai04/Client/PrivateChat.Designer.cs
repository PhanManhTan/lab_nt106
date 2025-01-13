namespace Client
{
    partial class PrivateChat
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
            this.tbChat = new System.Windows.Forms.RichTextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMess = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbChat.Location = new System.Drawing.Point(12, 49);
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.Size = new System.Drawing.Size(331, 337);
            this.tbChat.TabIndex = 0;
            this.tbChat.Text = "";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(252, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "\" \"";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMess
            // 
            this.tbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMess.Location = new System.Drawing.Point(12, 392);
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(266, 46);
            this.tbMess.TabIndex = 3;
            this.tbMess.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(284, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(59, 48);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // PrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbChat);
            this.Name = "PrivateChat";
            this.Text = "PrivateChat";
            this.Load += new System.EventHandler(this.PrivateChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbChat;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tbMess;
        private System.Windows.Forms.Button btnSend;
    }
}