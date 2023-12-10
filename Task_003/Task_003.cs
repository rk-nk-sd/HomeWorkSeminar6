using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Task_003 {
    public class Task_003 {
        public static void Main(string[] args) {
            string input = "Поп";
            System.Console.WriteLine(isPalendrom(input));
        }

        public static bool isPalendrom(string input) {
            return input.ToLower().SequenceEqual(input.ToLower().Reverse());
        }

    }
}