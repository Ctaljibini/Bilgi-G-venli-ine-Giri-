using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ().,?!";
        Vigenere vigenere = new Vigenere();
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            output.ReadOnly = true; // sadece okumak için kullanıyorum.

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void encrypt_Click(object sender, EventArgs e)
        {
            string txt = inputBox.Text;
            string key = keyBox.Text;
            if (string.IsNullOrEmpty(txt) || string.IsNullOrEmpty(key))
                MessageBox.Show("Please fill out the previous fields");
            string cipher = vigenere.encryption(txt, key);
            output.AppendText(cipher + Environment.NewLine);

        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            string cipher = inputBox.Text;
            string key = keyBox.Text;
            
            if (string.IsNullOrEmpty(cipher) || string.IsNullOrEmpty(key))
                MessageBox.Show("Please fill out the previous fields");

            string message = vigenere.decryption(cipher, key);
            output.AppendText(message + Environment.NewLine);

        }
    }
}
