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
    public partial class Authors_Books : Form
    {
        public Authors_Books()
        {
            InitializeComponent();
        }

        private void aUTHORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aUTHORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Authors_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
            this.bORROWED_BYTableAdapter.Fill(this.libraryDataSet.BORROWED_BY);
            // TODO: This line of code loads data into the 'libraryDataSet.WRITTEN_BY' table. You can move, or remove it, as needed.
            this.wRITTEN_BYTableAdapter.Fill(this.libraryDataSet.WRITTEN_BY);
            // TODO: This line of code loads data into the 'libraryDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
            // TODO: This line of code loads data into the 'libraryDataSet.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.libraryDataSet.AUTHOR);
            // TODO: This line of code loads data into the 'libraryDataSet.WRITTEN_BY' table. You can move, or remove it, as needed.
            this.wRITTEN_BYTableAdapter.Fill(this.libraryDataSet.WRITTEN_BY);
            // TODO: This line of code loads data into the 'libraryDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.libraryDataSet.BOOKS);
            // TODO: This line of code loads data into the 'libraryDataSet.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.libraryDataSet.AUTHOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form();
            home.Show();
            this.Hide();
        }

        private void a_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aUTHORDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aUTHORBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aUTHORBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aUTHORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void aUTHORDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=EL-HENNAWY\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select B_NAME , A_FNAME,A_LNAME  from AUTHOR , BOOKS , WRITTEN_BY  where BOOKS.B_ID = WRITTEN_BY.B_ID and AUTHOR.A_ID = WRITTEN_BY.A_ID  ", con);
            DataTable d =new DataTable() ;
            a.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authors_Form author = new Authors_Form();
            author.Show();
            this.Hide();
        }

        
    }
}
