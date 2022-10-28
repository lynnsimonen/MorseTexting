using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MorseTexting
{
    public class MorseAlpha
    {
        private static string[] alphaLetters { get; set; }
        private static string[] morseCode { get; set; }
        private static string morse { get; set; }
        public MorseAlpha()
        {

        }


        public static string DeCoder(string morse)
        {
            alphaLetters = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            morseCode = new[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            int indexCode;
                     
          
            indexCode = Array.IndexOf(morseCode, morse);
            if (indexCode != -1)
            {
                string letter = (string)alphaLetters.GetValue(indexCode);
                return letter;
            }
            else
            { 
                return ""; 
            }          
            
        }
    }
}
