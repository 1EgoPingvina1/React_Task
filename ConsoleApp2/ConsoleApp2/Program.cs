using ConsoleApp2.Models;
using ConsoleApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var handler = new ArrayHandler();
            Console.WriteLine(handler.Reverse("привет"));


            int[] arr1 = new int[] { 4, 6, 9 };
            foreach (int missing in handler.MissingElements(arr1))
            {
                Console.Write(missing + " ");
            }
            Console.WriteLine();

            int[] arr2 = new int[] { 2, 3, 4 };
            foreach (int missing in handler.MissingElements(arr2))
            {
                Console.Write(missing + " ");
            }
            Console.WriteLine();


            int[] arr3 = new int[] { 1, 3, 4 };
            foreach (int missing in handler.MissingElements(arr3))
            {
                Console.Write(missing + " "); 
            }
        }
    }
}
