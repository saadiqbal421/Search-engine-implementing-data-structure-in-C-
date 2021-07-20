using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Loop
{
    public partial class MainPage : Form
    {
        Node n = new Node();
        node ll = new node();
        public static AVL a = new AVL();
        public static int counter = 0;
        public static link_list li = new link_list();
        public static node sh = new node();


        public MainPage()
        {
            link_list L=new link_list();
            node Ln = new node();
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selected = comboBox1.SelectedItem.ToString();
            if(selected== "Sign Out")
            {
                MessageBox.Show(selected);
                new LogIn().Show();
                this.Hide();
            }
            else if(selected == "Add Web")
            {
                new Add_Webpage().Show();
                this.Hide();
            }
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\semester 4\data structure\loop\Websites.txt"))
            {
                string id = "", title = "", k1 = "", content = "";
                string line;
                int s = 0;
                int i = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    while (true)
                    {
                        int temp;
                        if (line[i] == '*')
                        {
                            Int32.TryParse(id, out temp);
                            n.Id = temp;
                            n.title = title;
                            n.keyw = k1;
                            n.abt = content;
                            a.root = a.insert(a.root, n);
                            n = null;
                            n = new Node();
                            //link list node
                            ll.data = temp;
                            ll.title = title;
                            ll.abt = content;
                            ll.key = k1;
                            li.enternode(ll);
                            ll = null;
                            ll = new node();

                            id = ""; title = ""; k1 = ""; content = "";
                            i = 0;
                            s = 0;
                            break;
                        }
                        if (line[i] == '^')
                        {
                            s++;
                            i++;
                            continue;
                        }

                        if (s == 0)
                            id += line[i];

                        if (s == 1)
                            title += line[i];

                        if (s == 2)
                            k1 += line[i];

                        if (s == 3)
                            content += line[i];

                        //Int32.TryParse(numberStr, out number);
                        i++;
                    }
                }
            }//end of file read
            string key=textBox1.Text.ToString();
            if (key != "")
            {
                sh=li.Search(textBox1.Text.ToString());
                if (sh != null)
                {
                    new Display().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter SomeThing Please");
                textBox1.Focus();
            }
        }
    }
}
