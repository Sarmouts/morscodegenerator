using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace morscodegenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your text: ");
                string str = Console.ReadLine();
                Dictionary<char, string> morscode = new Dictionary<char, string>()
                {
                    {'A',".-"},
                    {'a',".-"},
                    {'B',"-..."},
                    {'b',"-..."},
                    {'C',"-.-."},
                    {'c',"-.-."},
                    {'D',"-.."},
                    {'d',"-.."},
                    {'E',"."},
                    {'e',"."},
                    {'F',"..-."},
                    {'f',"..-."},
                    {'G',"--."},
                    {'g',"--."},
                    {'H',"...."},
                    {'h',"...."},
                    {'I',".."},
                    {'i',".."},
                    {'J',".---"},
                    {'j',".---"},
                    {'K',"-.-"},
                    {'k',"-.-"},
                    {'L',".-.."},
                    {'l',".-.."},
                    {'M',"--"},
                    {'m',"--"},
                    {'N',"-."},
                    {'n',"-."},
                    {'O',"---"},
                    {'o',"---"},
                    {'P',".--."},
                    {'p',".--."},
                    {'Q',"--.-"},
                    {'q',"--.-"},
                    {'R',".-."},
                    {'r',".-."},
                    {'S',"..."},
                    {'s',"..."},
                    {'T',"-"},
                    {'t',"-"},
                    {'U',"..-"},
                    {'u',"..-"},
                    {'V',"...-"},
                    {'v',"...-"},
                    {'W',".--"},
                    {'w',".--"},
                    {'X',"-..-"},
                    {'x',"-..-"},
                    {'Y',"-.--"},
                    {'y',"-.--"},
                    {'Z',"--.."},
                    {'z',"--.."},
                    {'0',"-----"},
                    {'1',".----"},
                    {'2',"..---"},
                    {'3',"...--"},
                    {'4',"....-"},
                    {'5',"....."},
                    {'6',"-...."},
                    {'7',"--..."},
                    {'8',"---.."},
                    {'9',"----."},
                };
                string encryptedText = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        encryptedText += " ";
                    }
                    else
                    {
                        encryptedText += morscode[str[i]] + " ";
                    }
                }
                Console.WriteLine("Here is your text in mors code and you hear your mors message:");
                Console.WriteLine(encryptedText);
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    if (encryptedText[i] == ' ')
                    {
                        Thread.Sleep(500);
                    }
                    else if (encryptedText[i] == '.')
                    {
                        Console.Beep(800, 166);
                    }
                    else if (encryptedText[i] == '-')
                    {
                        Console.Beep(800, 500);
                    }
                }
                Console.WriteLine("====================================================================");
                Console.WriteLine(); 
            }
        }
    }
}
