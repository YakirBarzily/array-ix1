using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int []grades = new int[5];
            int i;
            Console.WriteLine("please enter" + grades.Length + "grades");
            for (i = 0; i < grades.Length; i++) 
            grades[i] = int.Parse(Console.ReadLine());

            for (i = 0; i < grades.Length; i++)
            Console.Write(grades[i] + " ");
        }
    }
}
