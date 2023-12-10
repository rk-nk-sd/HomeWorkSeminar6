using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Task_001
{
    public class Task_001
    {
        public static void Main(string[] args) {
            char[,] charArray = {{'a','b'},{'c','d'}};

            System.Console.WriteLine(CreateStringFrom2DArray(charArray));
        }

        private static string CreateStringFrom2DArray(char[,] charArray) {
            string result = "";
            foreach(char item in charArray) {
                result += $"{item}";
            }
            return result;
        }
    }
}