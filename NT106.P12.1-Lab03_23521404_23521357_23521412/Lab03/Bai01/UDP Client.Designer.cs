namespace Lab3Bai01
{
    partial class UDP_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.ipremotehost = new System.Windows.Forms.TextBox();
            this.portclient = new System.Windows.Forms.TextBox();
            this.msg_client = new System.Windows.Forms.RichTextBox();
            this.butSndClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote host";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // ipremotehost
            // 
            this.ipremotehost.Location = new System.Drawing.Point(42, 57);
            this.ipremotehost.Name = "ipremotehost";
            this.ipremotehost.Size = new System.Drawing.Size(215, 22);
            this.ipremotehost.TabIndex = 3;
            this.ipremotehost.TextChanged += new System.EventHandler(this.ipremotehost_TextChanged);
            // 
            // portclient
            // 
            this.portclient.Location = new System.Drawing.Point(347, 57);
            this.portclient.Name = "portclient";
            this.portclient.Size = new System.Drawing.Size(176, 22);
            this.portclient.TabIndex = 4;
            this.portclient.TextChanged += new System.EventHandler(this.portclient_TextChanged);
            // 
            // msg_client
            // 
            this.msg_client.Location = new System.Drawing.Point(42, 133);
            this.msg_client.Name = "msg_client";
            this.msg_client.Size = new System.Drawing.Size(481, 96);
            this.msg_client.TabIndex = 5;
            this.msg_client.Text = "";
            this.msg_client.TextChanged += new System.EventHandler(this.msg_client_TextChanged);
            // 
            // butSndClient
            // 
            this.butSndClient.Location = new System.Drawing.Point(42, 246);
            this.butSndClient.Name = "butSndClient";
            this.butSndClient.Size = new System.Drawing.Size(75, 23);
            this.butSndClient.TabIndex = 6;
            this.butSndClient.Text = "Send";
            this.butSndClient.UseVisualStyleBackColor = true;
            this.butSndClient.Click += new System.EventHandler(this.butSndClient_Click);
            // 
            // UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 284);
            this.Controls.Add(this.butSndClient);
            this.Controls.Add(this.msg_client);
            this.Controls.Add(this.portclient);
            this.Controls.Add(this.ipremotehost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDP_Client";
            this.Text = "UDP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipremotehost;
        private System.Windows.Forms.TextBox portclient;
        private System.Windows.Forms.RichTextBox msg_client;
        private System.Windows.Forms.Button butSndClient;
    }
}