namespace CMSFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}