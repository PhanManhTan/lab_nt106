namespace Bai06
{
    partial class inforFood
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contributeLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.costLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.labelRemove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(155, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giá:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(155, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(155, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đóng góp:";
            // 
            // contributeLb
            // 
            this.contributeLb.AutoSize = true;
            this.contributeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.contributeLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.contributeLb.Location = new System.Drawing.Point(275, 109);
            this.contributeLb.Name = "contributeLb";
            this.contributeLb.Size = new System.Drawing.Size(64, 25);
            this.contributeLb.TabIndex = 6;
            this.contributeLb.Text = "label4";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addressLb.Location = new System.Drawing.Point(275, 79);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(64, 25);
            this.addressLb.TabIndex = 5;
            this.addressLb.Text = "label5";
            // 
            // costLb
            // 
            this.costLb.AutoSize = true;
            this.costLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.costLb.Location = new System.Drawing.Point(275, 49);
            this.costLb.Name = "costLb";
            this.costLb.Size = new System.Drawing.Size(64, 25);
            this.costLb.TabIndex = 4;
            this.costLb.Text = "label6";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameLb.ForeColor = System.Drawing.Color.Red;
            this.nameLb.Location = new System.Drawing.Point(155, 6);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(95, 36);
            this.nameLb.TabIndex = 7;
            this.nameLb.Text = "label7";
            // 
            // labelRemove
            // 
            this.labelRemove.AutoSize = true;
            this.labelRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelRemove.ForeColor = System.Drawing.Color.Red;
            this.labelRemove.Location = new System.Drawing.Point(481, 65);
            this.labelRemove.Name = "labelRemove";
            this.labelRemove.Size = new System.Drawing.Size(104, 25);
            this.labelRemove.TabIndex = 8;
            this.labelRemove.Text = "REMOVE";
            this.labelRemove.Visible = false;
            this.labelRemove.Click += new System.EventHandler(this.labelRemove_Click);
            // 
            // inforFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelRemove);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.contributeLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.costLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "inforFood";
            this.Size = new System.Drawing.Size(589, 146);
            this.Load += new System.EventHandler(this.inforFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contributeLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.Label costLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label labelRemove;
    }
}