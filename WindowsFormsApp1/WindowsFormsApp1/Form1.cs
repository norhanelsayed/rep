using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
         private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void usenumberonly(KeyPressEventArgs w)
        {
            switch (w.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                case (char)Keys.Back:
                    w.Handled = false;
                    break;
                default:
                    MessageBox.Show("please use numbers only ");
                    w.Handled = true;
                    break;


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumberonly(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumberonly(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumberonly(e);
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            usenumberonly(e);
        }
    }
}
