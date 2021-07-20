using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Loop
{
    public partial class LogIn : Form
    {
        Node n = new Node();
        node ll = new node();

        public static AVL a = new AVL();
        public static int counter = 0;
        public static link_list li = new link_list();
        public LogIn()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"D:\semester 4\data structure\loop\Websites.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //checking username and password
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="Admin" || txtUserName.Text == "User")
            {
                if (txtUserName.Text == "Admin")
                {
                    if (txtpassword.Text == "12345")
                    {
                        new SplashScreen().Show();
                        this.Hide();
                    }
                }
              //if password or input is wrong
                //else
                //{
                //    MessageBox.Show("Wrong username");
                 
                //}
            }
            else
            {
                MessageBox.Show("Wrong Username or password ");
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
