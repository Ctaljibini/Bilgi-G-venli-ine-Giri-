using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Vigenere
    {
        public static string alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ().,?!";

        // karakterlerin ineks numarası 0'dan 25'e
        public int[] getCharIndex1(string txt)
        {
            int size = txt.Length;
            int[] index = new int[size];

            for (int i = 0; i < size; i++)
            {
                index[i] += alphaChars.IndexOf(txt[i]);
            }
            return index;
        }

        public string encryption(string message, string key)
        {
            int[] messageCharIndex = getCharIndex1(message);
            int[] keyCharIndex = getCharIndex1(key);
            string cipher = "";

            int textLength = message.Length;
            int keyLength = key.Length;
            int temp;

            for (int n = 0; n < textLength; n++)
            {
                temp = (messageCharIndex[n] + keyCharIndex[n % keyLength]) % alphaChars.Length;
                cipher += alphaChars[temp];
            }
            return cipher;
        }

        public string decryption(string cipher, string key)
        {
            int[] cipherCharIndex = getCharIndex1(cipher);
            int[] keyCharIndex = getCharIndex1(key);

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

        public int[] GetCharsIndexes(string txt)
        {
            int size = txt.Length;
            int[] indexes = new int[size];
            int temp = 0;
            for(int i = 0; i < size; i++)
            {
                temp = alphaChars.IndexOf(txt[i]);
                indexes[i] = temp;
            }
            return indexes;
        }
    }
}
