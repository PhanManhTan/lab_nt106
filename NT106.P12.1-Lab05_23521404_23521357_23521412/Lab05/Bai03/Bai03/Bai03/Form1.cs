using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;
using System.Threading;
using System.Text.RegularExpressions;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MimeMessage> re = new List<MimeMessage>();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin Đăng Nhập!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string user = tbEmail.Text;
                    string pass = tbPassword.Text;

                    using (Pop3Client client = new Pop3Client())
                    {
                        client.Connect("pop.gmail.com",995, true);

                        client.Authenticate(user, pass);
                        int total = client.Count;
                        labelTotal.Text=total.ToString();
                        labelRecent.Text="10";  
                     
                        for (int i = 10 - 1; i >= 0; i--)
                        {
                                var message = client.GetMessage(i);
                                ListViewItem listViewItem = new ListViewItem(message.Subject);
                                string emailPattern = @"<([^>]+)>";
                                Match match = Regex.Match(message.From.ToString(), emailPattern);
                                if (match.Success)
                                {
                                string email = match.Groups[1].Value;
                                listViewItem.SubItems.Add(email);
                                }
                                DateTimeOffset sentDate = message.Date;
                                listViewItem.SubItems.Add(sentDate.ToString());
                                listView1.Items.Add(listViewItem);
                                re.Add(message);
                        }
                        client.Disconnect(true);
                    }
                    
                    
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {//int key = listView1.SelectedItems[0].Index;
            //MimeMessage x = re[key];
            //Form2 form2 = new Form2(x);
            //form2.ShowDialog();
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = listView1.SelectedItems[0].Index;
            MimeMessage x = re[key];
            Form2 form2 = new Form2(x);
            form2.ShowDialog();
        }
    }
}
