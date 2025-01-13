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

namespace Bai02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        

        private void btnReadFlle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Text File(*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
    
                int numberWord = 0;
                int numberCharacter = 0;
                int numberLine = 0;
                string line = "";
                string re = "";
                while ((line=sr.ReadLine()) != null)
                {
                    numberLine++;
                    string[] words = line.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);  //words
                    numberWord += words.Length;
                    for (int i=0; i<words.Length; i++)
                    {
                        numberCharacter += words[i].Length;
                    }
                    re += line + "\r\n";
                }

                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName); //information file
                long fileSizeInBytes = fileInfo.Length; //file size -> byte
            
                richTextBox1.Text = re;  //content file
                FileNametextBox.Text = fileInfo.Name; //file name
                SizetextBox.Text = SizeFile(fileSizeInBytes);  //file size
                ULRtextBox.Text = openFileDialog1.FileName; //url file
                LineCounttextBox.Text = numberLine.ToString(); //line  
                WordCounttextBox.Text = numberWord.ToString(); //words
                CharacterCounttextBox.Text = numberCharacter.ToString(); //character
                sr.Close();
                fs.Close();
            }

                
        }

        private string SizeFile(long fileSizeInBytes)
        {
            string fileSize = "";
            if (fileSizeInBytes < 100)
            {
                fileSize = fileSizeInBytes.ToString() + " Byte";
            }
            else if (fileSizeInBytes >= 100 && fileSizeInBytes < 1024000)
            {
                fileSize = (Math.Round((fileSizeInBytes / 1024.0), 2)).ToString() + " KB";
            }
            else if (fileSizeInBytes >= 1024000 && fileSizeInBytes < (1024 * 1024000))
            {
                fileSize = (Math.Round((fileSizeInBytes / (1024.0 * 1024)), 2)).ToString() + " MB";
            }
            else
            {
                fileSize = (Math.Round((fileSizeInBytes / (1024.0 * 1024 * 1024)), 2)).ToString() + " GB";
            }
            return fileSize;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
