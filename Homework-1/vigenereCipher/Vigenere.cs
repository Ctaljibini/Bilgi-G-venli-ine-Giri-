using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Vigenere
    {
        public static string alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ().,?!";
        public List<int> GetCharIndexes(string str)
        {
            List<int> charsAtPos = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                charsAtPos.Add(alphaChars.IndexOf(str[i]));
            }
            return charsAtPos;
        }

        public string encryption(string message, string key)
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

        public string decryption(string cipher, string key)
        {
            List<int> cipherCharIndex = GetCharIndexes(cipher);
            List<int> keyCharIndex = GetCharIndexes(key);

            int cipherLength = cipher.Length;
            int keyLength = key.Length;
            string message = "";
            int letter;

            for (int n = 0; n < cipherLength; n++)
            {
                letter = (cipherCharIndex[n] - keyCharIndex[n % keyLength] + alphaChars.Length) % alphaChars.Length;
                message += alphaChars[letter];
            }
            return message;
        }
    }
}
