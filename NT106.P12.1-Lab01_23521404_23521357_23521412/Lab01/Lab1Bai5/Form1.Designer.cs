namespace Lab1Bai5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phai = new System.Windows.Forms.ComboBox();
            this.diemmon3 = new System.Windows.Forms.TextBox();
            this.diemmon2 = new System.Windows.Forms.TextBox();
            this.diemmon1 = new System.Windows.Forms.TextBox();
            this.hoTen = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dsachthisinh = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaigt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.monhoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhoc3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trungbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploaihk = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dsachthisinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.phai);
            this.groupBox1.Controls.Add(this.diemmon3);
            this.groupBox1.Controls.Add(this.diemmon2);
            this.groupBox1.Controls.Add(this.diemmon1);
            this.groupBox1.Controls.Add(this.hoTen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thí Sinh";
            // 
            // phai
            // 
            this.phai.FormattingEnabled = true;
            this.phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.phai.Location = new System.Drawing.Point(85, 62);
            this.phai.Name = "phai";
            this.phai.Size = new System.Drawing.Size(143, 24);
            this.phai.TabIndex = 11;
            this.phai.SelectedIndexChanged += new System.EventHandler(this.phai_SelectedIndexChanged);
            // 
            // diemmon3
            // 
            this.diemmon3.Location = new System.Drawing.Point(391, 84);
            this.diemmon3.Name = "diemmon3";
            this.diemmon3.Size = new System.Drawing.Size(104, 22);
            this.diemmon3.TabIndex = 10;
            this.diemmon3.TextChanged += new System.EventHandler(this.mon3_TextChanged);
            // 
            // diemmon2
            // 
            this.diemmon2.Location = new System.Drawing.Point(391, 56);
            this.diemmon2.Name = "diemmon2";
            this.diemmon2.Size = new System.Drawing.Size(104, 22);
            this.diemmon2.TabIndex = 9;
            this.diemmon2.TextChanged += new System.EventHandler(this.mon2_TextChanged);
            // 
            // diemmon1
            // 
            this.diemmon1.Location = new System.Drawing.Point(391, 27);
            this.diemmon1.Name = "diemmon1";
            this.diemmon1.Size = new System.Drawing.Size(104, 22);
            this.diemmon1.TabIndex = 8;
            this.diemmon1.TextChanged += new System.EventHandler(this.mon1_TextChanged);
            // 
            // hoTen
            // 
            this.hoTen.Location = new System.Drawing.Point(85, 30);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(143, 22);
            this.hoTen.TabIndex = 7;
            this.hoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm Môn 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm Môn 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm Môn 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phái";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dsachthisinh
            // 
            this.Dsachthisinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dsachthisinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dsachthisinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoID,
            this.Hovaten,
            this.phaigt,
            this.monhoc1,
            this.monhoc2,
            this.monhoc3,
            this.trungbinh,
            this.xeploaihk,
            this.delete});
            this.Dsachthisinh.Location = new System.Drawing.Point(22, 227);
            this.Dsachthisinh.Name = "Dsachthisinh";
            this.Dsachthisinh.RowHeadersWidth = 51;
            this.Dsachthisinh.RowTemplate.Height = 24;
            this.Dsachthisinh.Size = new System.Drawing.Size(829, 212);
            this.Dsachthisinh.TabIndex = 1;
            this.Dsachthisinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh Sách Thí Sinh";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(208, 129);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(124, 23);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // SoID
            // 
            this.SoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoID.HeaderText = "ID";
            this.SoID.MinimumWidth = 6;
            this.SoID.Name = "SoID";
            this.SoID.ReadOnly = true;
            // 
            // Hovaten
            // 
            this.Hovaten.HeaderText = "Họ và Tên";
            this.Hovaten.MinimumWidth = 6;
            this.Hovaten.Name = "Hovaten";
            this.Hovaten.ReadOnly = true;
            this.Hovaten.Width = 125;
            // 
            // phaigt
            // 
            this.phaigt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phaigt.FillWeight = 110F;
            this.phaigt.HeaderText = "Phái";
            this.phaigt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.phaigt.MinimumWidth = 6;
            this.phaigt.Name = "phaigt";
            this.phaigt.ReadOnly = true;
            // 
            // monhoc1
            // 
            this.monhoc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.monhoc1.HeaderText = "Môn 1";
            this.monhoc1.MinimumWidth = 6;
            this.monhoc1.Name = "monhoc1";
            this.monhoc1.ReadOnly = true;
            this.monhoc1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monhoc1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monhoc1.Width = 49;
            // 
            // monhoc2
            // 
            this.monhoc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.monhoc2.HeaderText = "Môn 2";
            this.monhoc2.MinimumWidth = 6;
            this.monhoc2.Name = "monhoc2";
            this.monhoc2.ReadOnly = true;
            this.monhoc2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monhoc2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monhoc2.Width = 49;
            // 
            // monhoc3
            // 
            this.monhoc3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.monhoc3.HeaderText = "Môn 3";
            this.monhoc3.MinimumWidth = 6;
            this.monhoc3.Name = "monhoc3";
            this.monhoc3.ReadOnly = true;
            this.monhoc3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monhoc3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monhoc3.Width = 49;
            // 
            // trungbinh
            // 
            this.trungbinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.trungbinh.HeaderText = "Trung bình";
            this.trungbinh.MinimumWidth = 6;
            this.trungbinh.Name = "trungbinh";
            this.trungbinh.ReadOnly = true;
            this.trungbinh.Width = 99;
            // 
            // xeploaihk
            // 
            this.xeploaihk.FillWeight = 135F;
            this.xeploaihk.HeaderText = "Xếp loại";
            this.xeploaihk.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung Bình",
            "Yếu",
            "Kém"});
            this.xeploaihk.MinimumWidth = 6;
            this.xeploaihk.Name = "xeploaihk";
            this.xeploaihk.ReadOnly = true;
            this.xeploaihk.Width = 121;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete.HeaderText = "Xóa";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xóa";
            this.delete.ToolTipText = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dsachthisinh);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BaiTH5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dsachthisinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox phai;
        private System.Windows.Forms.TextBox diemmon3;
        private System.Windows.Forms.TextBox diemmon2;
        private System.Windows.Forms.TextBox diemmon1;
        private System.Windows.Forms.TextBox hoTen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Dsachthisinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewComboBoxColumn phaigt;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhoc3;
        private System.Windows.Forms.DataGridViewTextBoxColumn trungbinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn xeploaihk;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

