using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Bradley\Code\AdventOfCode\Day1\ExpenseReport.txt");
            int[] intLines = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                intLines[i] = Int32.Parse(lines[i]);
            }
            
            for (int i = 0; i < intLines.Length; i++)
            {
                var found = false;
                var answer = 0;
                int num1 = 0;
                int num2 = 0;
                for (int x = 1; x < lines.Length; x++)
                {
                    if (intLines[i] + intLines[x] == 2020)
                    {
                        answer = intLines[i] * intLines[x];
                        found = true;
                        num1 = intLines[i];
                        num2 = intLines[x];
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine("The answer is " + answer + " and the numbers are " + num1 + " and " + num2);
                    break;
                }
            }
        }
    }
}
