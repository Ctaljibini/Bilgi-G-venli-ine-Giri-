using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // sadece okumak için kullanıyorum.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            output.ReadOnly = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            string txt = inputBox.Text;

            output.AppendText(txt + Environment.NewLine);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
