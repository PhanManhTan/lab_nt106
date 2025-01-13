namespace Lab3Bai01
{
    partial class Dashboard
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
            this.butUDPsv = new System.Windows.Forms.Button();
            this.butUDPcl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butUDPsv
            // 
            this.butUDPsv.Location = new System.Drawing.Point(12, 26);
            this.butUDPsv.Name = "butUDPsv";
            this.butUDPsv.Size = new System.Drawing.Size(119, 44);
            this.butUDPsv.TabIndex = 0;
            this.butUDPsv.Text = "UDP Server";
            this.butUDPsv.UseVisualStyleBackColor = true;
            this.butUDPsv.Click += new System.EventHandler(this.butUDPsv_Click);
            // 
            // butUDPcl
            // 
            this.butUDPcl.Location = new System.Drawing.Point(215, 26);
            this.butUDPcl.Name = "butUDPcl";
            this.butUDPcl.Size = new System.Drawing.Size(119, 44);
            this.butUDPcl.TabIndex = 1;
            this.butUDPcl.Text = "UDP Client";
            this.butUDPcl.UseVisualStyleBackColor = true;
            this.butUDPcl.Click += new System.EventHandler(this.butUDPcl_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 101);
            this.Controls.Add(this.butUDPcl);
            this.Controls.Add(this.butUDPsv);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butUDPsv;
        private System.Windows.Forms.Button butUDPcl;
    }
}

