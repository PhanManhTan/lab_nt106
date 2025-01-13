using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Bai01 : Form
    {
        string filecontent = "";
        
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnReadFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "File Text(*.txt)|*txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                filecontent = sr.ReadToEnd();
                richTextBox1.Text = filecontent;

                sr.Close();
                fs.Close();
            }

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != " ")
            {
                filecontent = filecontent.ToUpper();
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save";
                saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog()== DialogResult.OK) 
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(filecontent);
                    sw.Close();
                    fs.Close();

                }
            }
        }
    }
}
