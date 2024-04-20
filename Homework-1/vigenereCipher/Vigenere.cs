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

        // Bir string alıp, bir tamsayı dizisi döndürür.
        public int[] getCharIndex(string txt)
        {
            int size = txt.Length;
            int[] index = new int[size];

            for (int i = 0; i < size; i++)
            {
                index[i] += alphaChars.IndexOf(txt[i]); // index'leri diziye ekle.
            }
            return index;
        }

        // Şifreleme Fonksiyonu
        public string encryption(string message, string key)
        {
            int[] messageCharIndex = getCharIndex(message);  // mesajın index'ler dizisi 
            int[] keyCharIndex = getCharIndex(key);          // Anahtar index'ler dizisi
            string cipher = "";

            int messageLength = message.Length;
            int keyLength = key.Length;
            int temp;

            for (int n = 0; n < messageLength; n++)
            {   // P + K = C mod(26), 26 alfabe için. Bu sistem büyük / küçük harfleri ve temel karakterleri içeriyor.
                temp = (messageCharIndex[n] + keyCharIndex[n % keyLength]) % alphaChars.Length; 
                                                         // anahtar uzunluğu yetmediği durumda tekrarlansın
                cipher += alphaChars[temp];
            }
            return cipher;
        }

        // Deşifreleme Fonksiyonu
        public string decryption(string cipher, string key)
        {
            int[] cipherCharIndex = getCharIndex(cipher);
            int[] keyCharIndex = getCharIndex(key);

            int cipherLength = cipher.Length;
            int keyLength = key.Length;
            string message = "";
            int temp;

            for (int n = 0; n < cipherLength; n++)
            {   // C - K = P mod(26)
                temp = (cipherCharIndex[n] - keyCharIndex[n % keyLength] + alphaChars.Length) % alphaChars.Length; 
                message += alphaChars[temp];
            }
            return message;
        }
    }
}
