namespace Lab1Bai2
{
    partial class BaiTH2
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
            this.nhapA = new System.Windows.Forms.TextBox();
            this.nhapB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tinhgiatri = new System.Windows.Forms.Button();
            this.nutxoa = new System.Windows.Forms.Button();
            this.nutthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Ketqua = new System.Windows.Forms.GroupBox();
            this.kqua = new System.Windows.Forms.TextBox();
            this.Ketqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nhapA
            // 
            this.nhapA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nhapA.Location = new System.Drawing.Point(130, 47);
            this.nhapA.Name = "nhapA";
            this.nhapA.Size = new System.Drawing.Size(239, 22);
            this.nhapA.TabIndex = 2;
            this.nhapA.TextChanged += new System.EventHandler(this.nhapA_TextChanged);
            // 
            // nhapB
            // 
            this.nhapB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhapB.Location = new System.Drawing.Point(519, 47);
            this.nhapB.Name = "nhapB";
            this.nhapB.Size = new System.Drawing.Size(258, 22);
            this.nhapB.TabIndex = 3;
            this.nhapB.TextChanged += new System.EventHandler(this.nhapB_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Comfortaa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.comboBox1.Location = new System.Drawing.Point(308, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 29);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tinhgiatri
            // 
            this.tinhgiatri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tinhgiatri.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhgiatri.Location = new System.Drawing.Point(50, 192);
            this.tinhgiatri.Name = "tinhgiatri";
            this.tinhgiatri.Size = new System.Drawing.Size(213, 48);
            this.tinhgiatri.TabIndex = 5;
            this.tinhgiatri.Text = "Tính các giá trị";
            this.tinhgiatri.UseVisualStyleBackColor = true;
            this.tinhgiatri.Click += new System.EventHandler(this.tinhgiatri_Click);
            // 
            // nutxoa
            // 
            this.nutxoa.Font = new System.Drawing.Font("Comfortaa", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutxoa.Location = new System.Drawing.Point(323, 192);
            this.nutxoa.Name = "nutxoa";
            this.nutxoa.Size = new System.Drawing.Size(158, 48);
            this.nutxoa.TabIndex = 6;
            this.nutxoa.Text = "Xóa";
            this.nutxoa.UseVisualStyleBackColor = true;
            this.nutxoa.Click += new System.EventHandler(this.nutxoa_Click);
            // 
            // nutthoat
            // 
            this.nutthoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nutthoat.Font = new System.Drawing.Font("Comfortaa", 11.2F);
            this.nutthoat.Location = new System.Drawing.Point(557, 192);
            this.nutthoat.Name = "nutthoat";
            this.nutthoat.Size = new System.Drawing.Size(218, 48);
            this.nutthoat.TabIndex = 7;
            this.nutthoat.Text = "Thoát";
            this.nutthoat.UseVisualStyleBackColor = true;
            this.nutthoat.Click += new System.EventHandler(this.nutthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 8;
            // 
            // Ketqua
            // 
            this.Ketqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ketqua.Controls.Add(this.kqua);
            this.Ketqua.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ketqua.Location = new System.Drawing.Point(31, 283);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(740, 181);
            this.Ketqua.TabIndex = 9;
            this.Ketqua.TabStop = false;
            this.Ketqua.Text = "KẾT QUẢ";
            this.Ketqua.Enter += new System.EventHandler(this.Ketqua_Enter);
            // 
            // kqua
            // 
            this.kqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kqua.BackColor = System.Drawing.SystemColors.Control;
            this.kqua.Location = new System.Drawing.Point(19, 29);
            this.kqua.Multiline = true;
            this.kqua.Name = "kqua";
            this.kqua.ReadOnly = true;
            this.kqua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.kqua.Size = new System.Drawing.Size(702, 146);
            this.kqua.TabIndex = 0;
            this.kqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaiTH2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 476);
            this.Controls.Add(this.Ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nutthoat);
            this.Controls.Add(this.nutxoa);
            this.Controls.Add(this.tinhgiatri);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nhapB);
            this.Controls.Add(this.nhapA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaiTH2";
            this.Text = "BaiTH2";
            this.Load += new System.EventHandler(this.BaiTH2_Load);
            this.Ketqua.ResumeLayout(false);
            this.Ketqua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nhapA;
        private System.Windows.Forms.TextBox nhapB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button tinhgiatri;
        private System.Windows.Forms.Button nutxoa;
        private System.Windows.Forms.Button nutthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Ketqua;
        private System.Windows.Forms.TextBox kqua;
    }
}

