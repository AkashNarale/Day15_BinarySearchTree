using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree UC");

            Console.Write("\nPlease select a UC no to get output: ");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    binaryUC1<int> UC1 = new binaryUC1<int>(56);
                    UC1.Insert(30);
                    UC1.Insert(70);
                    UC1.display();
                    break;
                case 2:
                    binaryUC2<int> UC2 = new binaryUC2<int>(56);
                    UC2.Insert(30);
                    UC2.Insert(70);
                    UC2.Insert(22);
                    UC2.Insert(40);
                    UC2.Insert(11);
                    UC2.Insert(3);
                    UC2.Insert(16);
                    UC2.Insert(60);
                    UC2.Insert(95);
                    UC2.Insert(65);
                    UC2.Insert(63);
                    UC2.Insert(67);
                    UC2.display();
                    UC2.size();
                    break;
                case 3:
                    binaryUC3<int> UC3 = new binaryUC3<int>(56);
                    UC3.Insert(30);
                    UC3.Insert(70);
                    UC3.Insert(22);
                    UC3.Insert(40);
                    UC3.Insert(11);
                    UC3.Insert(3);
                    UC3.Insert(16);
                    UC3.Insert(60);
                    UC3.Insert(95);
                    UC3.Insert(65);
                    UC3.Insert(63);
                    UC3.Insert(67);
                    UC3.display();
                    bool result = UC3.IfExists(35, UC3);
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }
            Console.ReadLine();
        }
    }
}
