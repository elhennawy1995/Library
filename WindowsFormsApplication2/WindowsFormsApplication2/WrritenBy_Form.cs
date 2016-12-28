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
    public partial class WrritenBy_Form : Form
    {
        public WrritenBy_Form()
        {
            InitializeComponent();
        }

        private void WrritenBy_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.WRITTEN_BY' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = "insert into WRITTEN_BY values ('" + textBox1.Text + "' , '" + textBox2.Text + "')";
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

            MyCommand.CommandText = "UPDATE WRITTEN_BY SET A_ID = '" + textBox2.Text + "' WHERE B_ID = '" + textBox1.Text + "'";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Update succeeded");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = MyConnection;
            MyConnection.Open();

            MyCommand.CommandText = "DELETE FROM WRITTEN_BY WHERE B_ID = '" + textBox1.Text + "' and A_ID = '" + textBox2.Text + "' ";
            MyCommand.ExecuteNonQuery();

            MyConnection.Close();
            MessageBox.Show("Deletion succeeded");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.wRITTEN_BYTableAdapter.Fill(this.libraryDataSet.WRITTEN_BY);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
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
            Clients_Form cl = new Clients_Form();
            cl.Show();
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
