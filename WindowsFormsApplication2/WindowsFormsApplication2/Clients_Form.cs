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
    public partial class Clients_Form : Form
    {
        public Clients_Form()
        {
            InitializeComponent();
        }

        private void Clients_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.CLIENTS' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = "insert into CLIENTS values ('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "')";
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

            MyCommand.CommandText = "update CLIENTS set C_Fname = '" + textBox2.Text + "' , C_Lname = '" + textBox3.Text + "' , PHONE_NUMBER ='" + textBox4.Text + "' where C_ID = '" + textBox1.Text + "'";
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

            MyCommand.CommandText = "delete from CLIENTS where C_ID = '" + textBox1.Text + "'";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.cLIENTSTableAdapter.Fill(this.libraryDataSet.CLIENTS);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Books_Form book = new Books_Form();
            book.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Category_Form cat = new Category_Form();
            cat.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Authors_Form au = new Authors_Form();
            au.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WrritenBy_Form wr = new WrritenBy_Form();
            wr.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Loans_Form lo = new Loans_Form();
            lo.Show();
            this.Hide();
        }
    }
}
