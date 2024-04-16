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
        public static string  alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
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
            string key = keyBox.Text;
            if (string.IsNullOrEmpty(txt) || string.IsNullOrEmpty(key))
                MessageBox.Show("Please fill out the previous fields");
            string cipher = encryption(txt, key);
            output.AppendText(cipher + Environment.NewLine);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        // karakterlerin ineks numarası 0'dan 25'e
        public static List<int> GetCharIndexes(string str)
        {
            List<int> charsAtPos = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                charsAtPos.Add(alphaChars.IndexOf(str[i]));
            }
            return charsAtPos;
        }

        public static string encryption(string message, string key)
        {
            List<int> messageCharIndex = GetCharIndexes(message);
            List<int> keyCharIndex = GetCharIndexes(key);
            string cipher = "";

            int textLength = message.Length;
            int keyLength = key.Length;
            int letter;

            for (int n = 0; n < textLength; n++)
            {
                letter = (messageCharIndex[n] + keyCharIndex[n % keyLength]) % alphaChars.Length; 
                cipher += alphaChars[letter];
            }
           return cipher;
        }

        public static string decryption(string cipher, string key)
        {
            List<int> cipherCharIndex = GetCharIndexes(cipher);
            List<int> keyCharIndex = GetCharIndexes(key);

            int cipherLength = cipher.Length;
            int keyLength = key.Length;
            string message = "";
            int letter;

            for(int n = 0; n < cipherLength ;n++)
            {
                letter = (cipherCharIndex[n] - keyCharIndex[n % keyLength] + alphaChars.Length) % alphaChars.Length;
                message += alphaChars[letter];
            }
            return message;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            string cipher = inputBox.Text;
            string key = keyBox.Text;
            
            if (string.IsNullOrEmpty(cipher) || string.IsNullOrEmpty(key))
                MessageBox.Show("Please fill out the previous fields");

            string message = decryption(cipher, key);
            output.AppendText(message + Environment.NewLine);

        }
    }
}
