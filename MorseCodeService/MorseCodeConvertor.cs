using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace MorseCodeService
{
    public class MorseCodeConvertor
    {
        public MorseCodeConvertor()
        { }

        #region Conversion Of String To MorseCode

        public string ConvertText(string input)
        {
            string[] words = input.ToUpper().Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                if (sb.Length != 0)
                    sb.Append("/");
                sb.Append(ConvertWord(word));
            }
            return sb.ToString();
        }

        private string ConvertWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in word)
            {
                if (sb.Length != 0 && sb[sb.Length - 1] != ' ')
                    sb.Append(" ");
                sb.Append(ConvertCharacter(ch));
            }
            return sb.ToString();
        }

        private string ConvertCharacter(char ch)
        {
            MorseCode morseCodes = new MorseCode();
            if (morseCodes.MorseCodes.Keys.Contains(ch))
                return morseCodes.MorseCodes[ch];
            else
                return string.Empty;
        }
        #endregion


        #region Conversion Of Morse Code To String
        public string ConvertMorse(string input)
        {
            string[] words = input.ToUpper().Split("/");
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                if (sb.Length != 0)
                    sb.Append(" ");
                sb.Append(ConvertMorseWord(word));
            }
            return sb.ToString();
        }


        private char ConvertMorseCode(string input)
        {
            MorseCode morseCodes = new MorseCode();
            if (morseCodes.MorseCodes.ContainsValue(input))
                return morseCodes.MorseCodes.First(x => x.Value.Equals(input)).Key;
            else
                return ' ';
        }

        private string ConvertMorseWord(string word)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = word.Split(" ");
            foreach (string d in words)
            {
                sb.Append(ConvertMorseCode(d));
            }
            return sb.ToString();
        }
        #endregion


    }
}
