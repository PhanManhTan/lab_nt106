namespace Server
{
    partial class Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.disChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListen.Location = new System.Drawing.Point(652, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(136, 64);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "LISTEN";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(495, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 64);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // disChat
            // 
            this.disChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.disChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.disChat.Location = new System.Drawing.Point(0, 82);
            this.disChat.Name = "disChat";
            this.disChat.ReadOnly = true;
            this.disChat.Size = new System.Drawing.Size(800, 368);
            this.disChat.TabIndex = 3;
            this.disChat.Text = "";
            this.disChat.TextChanged += new System.EventHandler(this.disChat_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disChat);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnListen);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox disChat;
    }
}

