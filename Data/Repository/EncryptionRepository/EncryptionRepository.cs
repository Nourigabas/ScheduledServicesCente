using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.EncryptionRepository
{
    public class EncryptionRepository : IEncryptionRepository
    {
        private readonly int key = 12;
        private readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghigklmnopqrstuvwxyz";
        public string Decryption(string cipher)
        {
            string EnCodeText = "";

            foreach (char ch in cipher)
            {
                if (alphabet.Contains(ch))
                {
                    int index = (alphabet.IndexOf(ch) - key + alphabet.Length) % alphabet.Length;
                    EnCodeText += alphabet[index];
                }
                else
                {
                    EnCodeText += ch;
                }
            }

            return EnCodeText;
        }

        public string Encryption(string plaintext)
        {
            //النص المشفر
            string CodeText = "";

            foreach (char temp in plaintext)
            {
                if (alphabet.Contains(temp))
                {
                    int index = (alphabet.IndexOf(temp) + key) % alphabet.Length;
                    CodeText += alphabet[index];
                }
                else
                {
                    //تمت مناقشة هذه الحالة بحيث في النص الذي تم ادخاله يحوي على قيمة غير موجودة في الاحرف 
                    //Ex : @#$%^ and space and .......
                    //في هذه تالحالة يتم وضع هذه القيم على حالها 
                    CodeText += temp;
                }
            }

            return CodeText;
        }
    }
}
