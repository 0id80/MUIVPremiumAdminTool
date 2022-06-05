using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Crypto
{
    //add seeds and sailt (don't drop keys and sipher)
    public class Encryptor
    {
        public static string Encrypt(string text)
        {
            Random random = new Random();
            List<string> cipher = new List<string>();
            foreach (char symbol in text)
            {
                int key = random.Next(0, 10000);
                cipher.Add($"{(symbol ^ key).ToString("X")}:{key.ToString("X")}");
            }
            return string.Join("|", cipher);
        }

        public static string Decrypt(string cipher)
        {
            List<char> text = new List<char>();
            foreach (string cipher_block in cipher.Split('|'))
            {
                List<string> cipher_block_sliced = cipher_block.Split(':').Take(2).ToList();
                int value = int.Parse(cipher_block_sliced[0], NumberStyles.HexNumber);
                int key = int.Parse(cipher_block_sliced[1], NumberStyles.HexNumber);
                text.Add((char)(value ^ key));
            }
            return string.Join("", text);
        }
    }
}
