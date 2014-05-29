using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP50Touch
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pass = "datecs-345@2014_111";
            string inputed = textBox1.Text;
            if (inputed == pass)
            {
                AdminMenu menu = new AdminMenu();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();
                this.Close();
            }
            else
	        {
                MessageBox.Show("Грешна парола!");
	        }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
                textBox1.Select();
            
        }
    }
}
