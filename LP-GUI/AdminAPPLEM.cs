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
    public partial class AdminAPPLEM : Form
    {
        public AdminAPPLEM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "datecs-345@2014_777";
            string inputed = textBox1.Text;
            if (inputed == pass)
            {
                APPLEM menu = new APPLEM();
                menu.StartPosition = FormStartPosition.CenterScreen;
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Грешна парола!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
