using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    internal class hashtableProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hash Table UC");

            Console.Write("\nPlease select a UC no to get output: ");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    hashTableUC1<string, string> hash = new hashTableUC1<string, string>(5);
                    hash.Add("0", "To");
                    hash.Add("1", "Be");
                    hash.Add("2", "Or");
                    hash.Add("3", "Not");
                    hash.Add("4", "To");
                    hash.Add("5", "Be");

                    string hash5 = hash.Get("5");
                    Console.WriteLine("5th Index Value: " + hash5);
                    string hash2 = hash.Get("2");
                    Console.WriteLine("2nd Index Value: " + hash2);
                    break;
                case 2:
                    break;

            }                    
            Console.ReadKey();
        }
    }
}
