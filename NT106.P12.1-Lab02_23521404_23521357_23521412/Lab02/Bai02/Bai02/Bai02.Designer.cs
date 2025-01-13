namespace Bai02
{
    partial class Bai02
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
            this.btnReadFlle = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.FileNametextBox = new System.Windows.Forms.TextBox();
            this.ULRtextBox = new System.Windows.Forms.TextBox();
            this.SizetextBox = new System.Windows.Forms.TextBox();
            this.LineCounttextBox = new System.Windows.Forms.TextBox();
            this.WordCounttextBox = new System.Windows.Forms.TextBox();
            this.CharacterCounttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnReadFlle
            // 
            this.btnReadFlle.Location = new System.Drawing.Point(12, 12);
            this.btnReadFlle.Name = "btnReadFlle";
            this.btnReadFlle.Size = new System.Drawing.Size(422, 56);
            this.btnReadFlle.TabIndex = 0;
            this.btnReadFlle.Text = "Read From File";
            this.btnReadFlle.UseVisualStyleBackColor = true;
            this.btnReadFlle.Click += new System.EventHandler(this.btnReadFlle_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox1.Location = new System.Drawing.Point(440, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(615, 451);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(422, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FileNametextBox
            // 
            this.FileNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FileNametextBox.Location = new System.Drawing.Point(119, 84);
            this.FileNametextBox.Name = "FileNametextBox";
            this.FileNametextBox.ReadOnly = true;
            this.FileNametextBox.Size = new System.Drawing.Size(315, 30);
            this.FileNametextBox.TabIndex = 3;
            // 
            // ULRtextBox
            // 
            this.ULRtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ULRtextBox.Location = new System.Drawing.Point(119, 190);
            this.ULRtextBox.Name = "ULRtextBox";
            this.ULRtextBox.ReadOnly = true;
            this.ULRtextBox.Size = new System.Drawing.Size(315, 30);
            this.ULRtextBox.TabIndex = 4;
            // 
            // SizetextBox
            // 
            this.SizetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SizetextBox.Location = new System.Drawing.Point(119, 141);
            this.SizetextBox.Name = "SizetextBox";
            this.SizetextBox.ReadOnly = true;
            this.SizetextBox.Size = new System.Drawing.Size(315, 30);
            this.SizetextBox.TabIndex = 5;
            // 
            // LineCounttextBox
            // 
            this.LineCounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LineCounttextBox.Location = new System.Drawing.Point(119, 241);
            this.LineCounttextBox.Name = "LineCounttextBox";
            this.LineCounttextBox.ReadOnly = true;
            this.LineCounttextBox.Size = new System.Drawing.Size(315, 30);
            this.LineCounttextBox.TabIndex = 6;
            // 
            // WordCounttextBox
            // 
            this.WordCounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.WordCounttextBox.Location = new System.Drawing.Point(119, 288);
            this.WordCounttextBox.Name = "WordCounttextBox";
            this.WordCounttextBox.ReadOnly = true;
            this.WordCounttextBox.Size = new System.Drawing.Size(315, 30);
            this.WordCounttextBox.TabIndex = 7;
            // 
            // CharacterCounttextBox
            // 
            this.CharacterCounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CharacterCounttextBox.Location = new System.Drawing.Point(119, 336);
            this.CharacterCounttextBox.Name = "CharacterCounttextBox";
            this.CharacterCounttextBox.ReadOnly = true;
            this.CharacterCounttextBox.Size = new System.Drawing.Size(315, 30);
            this.CharacterCounttextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Word count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Character count";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterCounttextBox);
            this.Controls.Add(this.WordCounttextBox);
            this.Controls.Add(this.LineCounttextBox);
            this.Controls.Add(this.SizetextBox);
            this.Controls.Add(this.ULRtextBox);
            this.Controls.Add(this.FileNametextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnReadFlle);
            this.MaximizeBox = false;
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFlle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox FileNametextBox;
        private System.Windows.Forms.TextBox ULRtextBox;
        private System.Windows.Forms.TextBox SizetextBox;
        private System.Windows.Forms.TextBox LineCounttextBox;
        private System.Windows.Forms.TextBox WordCounttextBox;
        private System.Windows.Forms.TextBox CharacterCounttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

