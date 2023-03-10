using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDatabaseDataset.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDatabaseDataset.tblWorker);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void objectDataProviderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void form2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void objectDataProviderBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDatabaseDataset.tblWorker);
            MessageBox.Show("The Worker Table is updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDatabaseDataset.tblWorker.clear();
            sqlDataAdapterl.Fill(this.cMSDatabaseDataset.tblWorker);
        }
    }
}
