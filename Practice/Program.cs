using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Enter the range to display triangle format");
            val=int.Parse(Console.ReadLine());
            int i, j;
            for(i=1; i <= val; i++)
            {
                for (j = 1; j <=val- i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }


    }
}
