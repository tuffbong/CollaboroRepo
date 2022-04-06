using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretCode2
{
    public class Collaboro
    {
        private static Dictionary<int, string> codeBox = new Dictionary<int, string>
            {
                { 1, "C" },
                { 2, "F" },
                { 3, "A" },
                { 4, "W" },
                { 5, "U" },
                { 6, "T" },
                { 7, "Y" },
                { 8, "L" },
                { 9, "I" },
                { 10, "S" },
                { 11, "M" },
                { 12, "H" },
                { 13, "R" },
                { 14, "N" },
                { 15, "Q" },
                { 16, "O" },
                { 17, "B" },
                { 18, "E" }

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Code Box > " + String.Join(",", codeBox.Select(x=> String.Format("({0},{1})", x.Key, x.Value))));
            Console.WriteLine("Code > ");
            Console.WriteLine("Solution is > " + Decrypt(Console.ReadLine()));
        }

        public static string Decrypt(string code)
        {
            string[] word = code.Split(" ");
            string[] codeKey;
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                codeKey = word[i].Split(",");

                for (int j = 0; j < codeKey.Length; j++)
                {
                    if (codeBox.ContainsKey(Convert.ToInt16(codeKey[j])))
                        message.Append(codeBox.Where(x => x.Key.ToString() == codeKey[j]).FirstOrDefault().Value);
                }

                if(i < word.Length - 1)
                message.Append(" ");
            }  
                
            return message.ToString();
        }
    }
}
