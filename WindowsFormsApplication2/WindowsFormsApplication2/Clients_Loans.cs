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
    public partial class Clients_Loans : Form
    {
        public Clients_Loans()
        {
            InitializeComponent();
        }

        private void cLIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
            this.bORROWED_BYTableAdapter.Fill(this.libraryDataSet.BORROWED_BY);
            // TODO: This line of code loads data into the 'libraryDataSet.CLIENTS' table. You can move, or remove it, as needed.
            this.cLIENTSTableAdapter.Fill(this.libraryDataSet.CLIENTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form();
            home.Show();
            this.Hide();
        }
    }
}
