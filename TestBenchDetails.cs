using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDBManagement
{
    public partial class TestBenchDetails : Form
    {
        public void frmValidate()
        {
            if (txtTestBench.Text == "")
            {
                MessageBox.Show("Enter Test Bench Name !");
                txtTestBench.Focus();
            }
            else if (txtIPAddress.Text == "")
            {
                MessageBox.Show("Enter IP Address !");
                txtIPAddress.Focus();
            }
            else if (txtDatabase.Text == "")
            {
                MessageBox.Show("Enter Database Name !");
                txtDatabase.Focus();
            }
            else if (txtUser.Text== "")
            {
                MessageBox.Show("Enter User Name !");
                txtUser.Focus();
            } 
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter Password !");
                txtPassword.Focus();
            }
            
        }
        public TestBenchDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TestResult_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            frmValidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTestBench_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
