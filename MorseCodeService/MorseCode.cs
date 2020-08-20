using System.Collections.Generic;

namespace MorseCodeService
{
    public class MorseCode
    {
        private readonly Dictionary<char, string> _codes;

        public MorseCode() 
        {
            _codes = new Dictionary<char, string>();
            _codes.Add('A', ".-");
            _codes.Add('B', "-...");
            _codes.Add('C', "-.-.");
            _codes.Add('D', "-..");
            _codes.Add('E', ".");
            _codes.Add('F', "..-.");
            _codes.Add('G', "--.");
            _codes.Add('H', "....");
            _codes.Add('I', "..");
            _codes.Add('J', ".---");
            _codes.Add('K', "-.-");
            _codes.Add('L', ".-..");
            _codes.Add('M', "--");
            _codes.Add('N', "-.");
            _codes.Add('O', "---");
            _codes.Add('P', ".--.");
            _codes.Add('Q', "--.-");
            _codes.Add('R', ".-.");
            _codes.Add('S', "...");
            _codes.Add('T', "-");
            _codes.Add('U', "..-");
            _codes.Add('V', "...-");
            _codes.Add('W', ".--");
            _codes.Add('X', "-..-");
            _codes.Add('Y', "-.--");
            _codes.Add('Z', "--..");
            _codes.Add('1', ".----");
            _codes.Add('2', "..---");
            _codes.Add('3', "...--");
            _codes.Add('4', "....-");
            _codes.Add('5', ".....");
            _codes.Add('6', "-....");
            _codes.Add('7', "--...");
            _codes.Add('8', "---..");
            _codes.Add('9', "----.");
            _codes.Add('0', "-----");
        }

        public Dictionary<char, string> MorseCodes => _codes;
    }
}
