using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, welcome to the new program, this is cool");
        }
        
        private void sayHello() 
        {
        MessageBox.Show("Hello New User!", "New User", MessageBoxButtons.OK, MessageBoxIcon.INFORMATION);
        }
    }
}
