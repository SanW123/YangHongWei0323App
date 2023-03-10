using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if(textBox1.Text == "")
            {
                errorCustomer.SetError(textBox1, "Please Specify a Valid Car Number.");
                flag = false;
            }
            else
            {
                errorCustomer.SetError(textBox1, "");
            }
            if (textBox2.Text == "")
            {
                errorCustomer.SetError(textBox2, "Please Specify a Valid nmae.");
                flag = false;
            }
            else
            {
                errorCustomer.SetError(textBox2, "");
            }
            if (textBox3.Text == "")
            {
                errorCustomer.SetError(textBox3, "Please Specify a Valid address.");
                flag = false;
            }
            else
            {
                errorCustomer.SetError(textBox3, "");
            }
            if (textBox4.Text == "")
            {
                errorCustomer.SetError(textBox4, "Please Specify a Valid Make.");
                flag = false;
            }
            else
            {
                errorCustomer.SetError(textBox4, "");
            }
            if (flag == false)
                return;
            else
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            errorCustomer.SetError(textBox1, "");
            errorCustomer.SetError(textBox2, "");
            errorCustomer.SetError(textBox3, "");
            errorCustomer.SetError(textBox4, "");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
