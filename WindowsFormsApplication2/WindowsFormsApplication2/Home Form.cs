using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Category_Form form1 =new Category_Form ();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books_Form books = new Books_Form();
            books.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authors_Form author = new Authors_Form();
            author.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clients_Form client = new Clients_Form();
            client.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WrritenBy_Form wrriten = new WrritenBy_Form();
            wrriten.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Loans_Form loan = new Loans_Form();
            loan.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
