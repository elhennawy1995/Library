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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDataSet.BORROWED_BY' table. You can move, or remove it, as needed.
            this.BORROWED_BYTableAdapter.Fill(this.LibraryDataSet.BORROWED_BY);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loans_Form lo = new Loans_Form();
            lo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_Form h = new Home_Form();
            h.Show();
            this.Hide();
        }
    }
}
