using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Loans_Form : Form
    {
        public Loans_Form()
        {
            InitializeComponent();
        }

        private void Loans_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = "insert into BORROWED_BY values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "')";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Insertion succeeded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = "update BORROWED_BY set  BORROW_DATE= '" + textBox3.Text + "' , DUE_DATE= '" + textBox4.Text + "' , FINE= '" + textBox5.Text + "' where C_ID = '" + textBox2.Text + "' and B_ID = '" + textBox1.Text + "' ";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Update was successfully completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = " delete from BORROWED_BY where C_ID = '" + textBox2.Text + "' ";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bORROWED_BYTableAdapter.Fill(this.libraryDataSet.BORROWED_BY);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clients_Loans form2 = new Clients_Loans();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Books_Form book = new Books_Form();
            book.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Category_Form cat = new Category_Form();
            cat.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Authors_Form au = new Authors_Form();
            au.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WrritenBy_Form wr = new WrritenBy_Form();
            wr.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clients_Form cl = new Clients_Form();
            cl.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            f.Show();
            this.Hide();
        }
    }
}
