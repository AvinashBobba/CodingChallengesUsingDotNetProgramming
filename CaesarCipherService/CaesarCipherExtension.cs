using System;
using System.Text;

namespace CaesarCipherService
{
    public static class CaesarCipherExtension
    {
        #region FirstApproach

        public static string Encoder(string input, int number) { return Chripset(input, number); }

        public static string Chripset(string input, int number)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    char ch = (char)(((int)input[i] +
                                    number - 65) % 26 + 65);
                    result.Append(ch);
                }
                else if (char.IsLower(input[i]))
                {
                    char ch = (char)(((int)input[i] +
                                    number - 97) % 26 + 97);
                    result.Append(ch);
                }
                else
                {
                    char ch = input[i];
                    result.Append(ch);
                }
            }
            return result.ToString();

        }

        public static string Decoder(string input, int number) { return Chripset(input, number - 26); }


        #endregion

        #region SecondApproach
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        public static void CeaserCipher(string input, int key, bool isEncrypt)
        {
            if (isEncrypt)
            {
                string cipherText = Encipher(input, key);
                Console.WriteLine(cipherText);
                Console.Write("\n");
            }
            else
            {
                string cipherText = CaesarCipherExtension.Decipher(input, key);
                Console.WriteLine(cipherText);
                Console.Write("\n");
            }

        }
        #endregion
    }
}
