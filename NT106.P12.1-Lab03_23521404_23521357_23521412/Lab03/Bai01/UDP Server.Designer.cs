namespace Lab3Bai01
{
    partial class UDP_Server
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
            this.PortSV = new System.Windows.Forms.TextBox();
            this.rcv_msgSV = new System.Windows.Forms.RichTextBox();
            this.butLisServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Received messages";
            // 
            // PortSV
            // 
            this.PortSV.Location = new System.Drawing.Point(75, 36);
            this.PortSV.Name = "PortSV";
            this.PortSV.Size = new System.Drawing.Size(145, 22);
            this.PortSV.TabIndex = 2;
            this.PortSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rcv_msgSV
            // 
            this.rcv_msgSV.Location = new System.Drawing.Point(40, 88);
            this.rcv_msgSV.Name = "rcv_msgSV";
            this.rcv_msgSV.ReadOnly = true;
            this.rcv_msgSV.Size = new System.Drawing.Size(579, 350);
            this.rcv_msgSV.TabIndex = 3;
            this.rcv_msgSV.Text = "";
            this.rcv_msgSV.TextChanged += new System.EventHandler(this.rcv_msgSV_TextChanged);
            // 
            // butLisServer
            // 
            this.butLisServer.Location = new System.Drawing.Point(515, 30);
            this.butLisServer.Name = "butLisServer";
            this.butLisServer.Size = new System.Drawing.Size(104, 35);
            this.butLisServer.TabIndex = 4;
            this.butLisServer.Text = "Listen";
            this.butLisServer.UseVisualStyleBackColor = true;
            this.butLisServer.Click += new System.EventHandler(this.butLisServer_Click);
            // 
            // UDP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.butLisServer);
            this.Controls.Add(this.rcv_msgSV);
            this.Controls.Add(this.PortSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDP_Server";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortSV;
        private System.Windows.Forms.RichTextBox rcv_msgSV;
        private System.Windows.Forms.Button butLisServer;
    }
}