using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Crypto
{
    public class Encryptor
    {
        protected class KeyManager
        {
            private string source_key = @"(cO{e'vpFeWM2i:elu18}(0p[L;k/6E&[NhvhA\pxtB)/>=y3!Hr=GjeS!Z)=!p%";
            private int init_key;
            private Random random;
            private int key_num;

            public KeyManager(int init_num)
            {
                init_key = init_num;
                random = new Random(source_key[init_key % source_key.Length]);
            }

            public int Next()
            {
                key_num++;
                return random.Next(0, init_key ^ source_key[key_num % source_key.Length]);
            }
        }

        public static string Encrypt(string text)
        {
            KeyManager key_manager = new KeyManager(text.Length);
            List<string> cipher = new List<string>();
            foreach (char symbol in text)
            {
                cipher.Add((symbol ^ key_manager.Next()).ToString("X"));
            }
            return string.Join(":", cipher);
        }

        public static string Decrypt(string cipher)
        {
            string[] cipher_list = cipher.Split(':');
            KeyManager key_manager = new KeyManager(cipher_list.Length);
            List<char> text = new List<char>();
            foreach (string encrypted_char in cipher_list)
            {
                text.Add((char)(int.Parse(encrypted_char, NumberStyles.HexNumber) ^ key_manager.Next()));
            }
            return string.Join("", text);
        }
    }
}
