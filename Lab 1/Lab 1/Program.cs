//Bogdan Livadaru



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //making title beatiful
            Console.Title = "Car Lab";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("__Welcome to my car class practice lab.___");

            //initiating SportsCar object
            SportsCar sc = new SportsCar();
            //calling the PrintName method from the initiated object
            sc.PrintName();
        }
    }
}
