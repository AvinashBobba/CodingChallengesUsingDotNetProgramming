using System;
using System.Text.RegularExpressions;

namespace MorseCodeService
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            while (quit)
            {
                quit = ValidateUserInput();
            }
        }

        public static bool ValidateUserInput()
        {
            MorseCodeConvertor morseCodeConvertor = new MorseCodeConvertor();

            Console.WriteLine("Select an Option  :");
            Console.WriteLine("Option A : Text to Morse Code || Option B : Morse Code to Text");
            var userOption = Console.ReadLine();
            Console.WriteLine("Enter a string to Parse:");
            var userInput = Console.ReadLine();
            if (IsQuit(userInput))
            {
                if (userOption.Equals("a", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(morseCodeConvertor.ConvertText(userInput));

                }
                if (userOption.Equals("b", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine(morseCodeConvertor.ConvertMorse(userInput));
                }
            }
            else
                return false;
            return true;
        }

        public static bool IsQuit(string userInput)
        {
            if (string.IsNullOrEmpty(userInput)) { ValidateUserInput(); }
            if (userInput.Equals("q", StringComparison.InvariantCultureIgnoreCase)) { return false; }
            return true;
        }
    }
}
