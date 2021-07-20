using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            string n, d;

            n=MainPage.sh.title;
            d = MainPage.sh.abt;

            textBox1.Text = n;
            textBox2.Text = d;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
