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
    public partial class Books_Category : Form
    {
        public Books_Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con =new SqlConnection ("Data Source=EL-HENNAWY\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlDataAdapter adt=new SqlDataAdapter ("select B_NAME , CAT_NAME from BOOKS , CATEGORY where BOOKS.CAT_ID = CATEGORY.CAT_ID" , con);
            DataTable dt =new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource=dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_Form home =new Home_Form();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Books_Form b = new Books_Form();
            b.Show();
            this.Hide();
        }
    }
}
