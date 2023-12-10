using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_004
{
    public class Task_004
    {
        public static void Main(string[] args) {
            string input = "Hello World";
            System.Console.WriteLine(GetReversWords(input));
        }

        public static string GetReversWords(string input) {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string result = "";
            foreach(string item in words) {
                result += $"{item}" + " ";
            }
            return result.Trim();
        }
    }
}