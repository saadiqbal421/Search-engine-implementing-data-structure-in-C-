using System;
using System.IO;
using System.Windows.Forms;

namespace Loop
{
    public partial class Add_Webpage : Form
    {
        int i;
        Node N;
        node n=new node();
        

        public Add_Webpage()
        {
            
            i = LogIn.counter;
            InitializeComponent();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Webpage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString() != "")
            {
                if (textBox3.Text.ToString() != "")
                {
                    if (textBox4.Text.ToString() != "")
                    {
                        N = null;
                        N = new Node();
                        i++;
                        N.Id = i;
                        N.height = 1;
                        N.left = null;
                        N.right = null;
                        N.keyw = textBox3.Text.ToString();
                        N.title = textBox2.Text.ToString();
                        N.abt = textBox4.Text.ToString();

                        //link list
                        n.data = i;
                        n.key = textBox3.Text.ToString();
                        n.title = textBox2.Text.ToString();
                        n.abt = textBox4.Text.ToString();
                        n = null;
                        n = new node();

                        LogIn.a.root = LogIn.a.insert(LogIn.a.root, N);
                        LogIn.li.enternode(n);
                        using (StreamWriter stream = new FileInfo(@"D:\semester 4\data structure\loop\Websites.txt").AppendText())
                        {
                            string w = i.ToString() + "^" + N.title + "^" + N.keyw + "^" + N.abt + "*";
                            stream.WriteLine(w);
                        }

                        new MainPage().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kindly Add Description");
                        textBox4.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kindly Enter KeyWord");
                    textBox3.Focus();
                }
            }
            else
            {
                MessageBox.Show("Kindly Add Title");
                textBox2.Focus();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}