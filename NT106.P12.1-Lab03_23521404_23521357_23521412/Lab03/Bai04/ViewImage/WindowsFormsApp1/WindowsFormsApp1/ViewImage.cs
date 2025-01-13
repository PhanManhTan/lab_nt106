using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewImage : Form
    {
        public System.Drawing.Image image;
        public ViewImage()
        {
            InitializeComponent();
           
        }
        public void Viewimage(byte[] x)
        {
            InitializeComponent();
            image = Lay(x);
            view(image);
        }
        byte[] x;
        private void ViewImage_Load(object sender, EventArgs e)
        {
        }
        public void view(System.Drawing.Image image)
        {
            pictureBox1.Image = image; 
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
        }
        private Image Lay(byte[] x)
        {
            using (MemoryStream ms = new MemoryStream(x))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose";
            ofd.Filter = "All file(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                byte[] x = converterDemo(image);
                view(Lay(x));
            }
        }
    }
}
