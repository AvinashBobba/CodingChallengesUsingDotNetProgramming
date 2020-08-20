using CaesarCipherService;
using System;

namespace Caesar_Cipher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool quit = true;
            while (quit)
            {
                quit = ValidateUserInput();
            }
        }

        public static bool ValidateUserInput()
        {
            Console.WriteLine("Type a string  :");
            var userInput = Console.ReadLine();
            if (userInput.Equals("q", StringComparison.InvariantCultureIgnoreCase)) { return false; }
            Console.WriteLine("Enter a key :");
            var KeyInput = Console.ReadLine();
            if (!Int32.TryParse(KeyInput, out int key))
            {
                Console.WriteLine("Key should be a numeric value");
                ValidateUserInput();
            }
            Console.WriteLine("Encrypty or Decrypt :");
            string encrypt = Console.ReadLine();
            bool isEncrypt = false;

            isEncrypt = encrypt.Equals("encrypt", StringComparison.InvariantCultureIgnoreCase);
            CaesarCipherExtension.CeaserCipher(userInput, key, isEncrypt);
            return true;
        }
    }
}