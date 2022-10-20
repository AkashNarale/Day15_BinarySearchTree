using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hash Table UC");

            Console.Write("\nPlease select a UC no to get output: ");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    hashTableUC1<string, string> hash1 = new hashTableUC1<string, string>(5);
                    hash1.Add("0", "To");
                    hash1.Add("1", "Be");
                    hash1.Add("2", "Or");
                    hash1.Add("3", "Not");
                    hash1.Add("4", "To");
                    hash1.Add("5", "Be");

                    string hash15 = hash1.Get("5");
                    Console.WriteLine("5th Index Value: " + hash15);
                    string hash12 = hash1.Get("2");
                    Console.WriteLine("2nd Index Value: " + hash12);
                    break;
                case 2:
                    hashTableUC2<string, string> hash2 = new hashTableUC2<string, string>(18);
                    //“Paranoids are not paranoid because they are paranoid but
                    //because they keep putting themselves deliberately into paranoid avoidable situations”
                    hash2.Add("0", "Paranoids");
                    hash2.Add("1", "are");
                    hash2.Add("2", "not");
                    hash2.Add("3", "paranoid");
                    hash2.Add("4", "because");
                    hash2.Add("5", "they");
                    hash2.Add("6", "are");
                    hash2.Add("7", "paranoid");
                    hash2.Add("8", "but");
                    hash2.Add("9", "because");
                    hash2.Add("10", "they");
                    hash2.Add("11", "keep");
                    hash2.Add("12", "putting");
                    hash2.Add("13", "themselves");
                    hash2.Add("14", "deliberately");
                    hash2.Add("15", "into");
                    hash2.Add("16", "paranoid");
                    hash2.Add("17", "avoidable");
                    hash2.Add("18", "situations");

                    string hash20 = hash2.Get("0");
                    Console.WriteLine("0th index value:" + hash20);
                    string hash21 = hash2.Get("1");
                    Console.WriteLine("1th index value:" + hash21);
                    string hash22 = hash2.Get("2");
                    Console.WriteLine("2th index value:" + hash22);
                    string hash23 = hash2.Get("3");
                    Console.WriteLine("3th index value:" + hash23);
                    string hash24 = hash2.Get("4");
                    Console.WriteLine("4th index value:" + hash24);
                    string hash25 = hash2.Get("5");
                    Console.WriteLine("5th index value:" + hash25);
                    string hash26 = hash2.Get("6");
                    Console.WriteLine("6th index value:" + hash26);
                    string hash27 = hash2.Get("7");
                    Console.WriteLine("7th index value:" + hash27);
                    string hash28 = hash2.Get("8");
                    Console.WriteLine("8th index value:" + hash28);
                    string hash29 = hash2.Get("9");
                    Console.WriteLine("9th index value:" + hash29);
                    string hash30 = hash2.Get("10");
                    Console.WriteLine("10th index value:" + hash30);
                    string hash31 = hash2.Get("11");
                    Console.WriteLine("11th index value:" + hash31);
                    string hash32 = hash2.Get("12");
                    Console.WriteLine("12th index value:" + hash32);
                    string hash33 = hash2.Get("13");
                    Console.WriteLine("13th index value:" + hash33);
                    string hash34 = hash2.Get("14");
                    Console.WriteLine("14th index value:" + hash34);
                    string hash35 = hash2.Get("15");
                    Console.WriteLine("15th index value:" + hash35);
                    string hash36 = hash2.Get("16");
                    Console.WriteLine("16th index value:" + hash36);
                    string hash37 = hash2.Get("17");
                    Console.WriteLine("17th index value:" + hash37);
                    string hash38 = hash2.Get("18");
                    Console.WriteLine("18th index value:" + hash38);
                    break;
                case 3:
                    hashTableUC3<string, string> hash3 = new hashTableUC3<string, string>(18);
                    //“Paranoids are not paranoid because they are paranoid but
                    //because they keep putting themselves deliberately into paranoid avoidable situations”
                    hash3.Add("0", "Paranoids");
                    hash3.Add("1", "are");
                    hash3.Add("2", "not");
                    hash3.Add("3", "paranoid");
                    hash3.Add("4", "because");
                    hash3.Add("5", "they");
                    hash3.Add("6", "are");
                    hash3.Add("7", "paranoid");
                    hash3.Add("8", "but");
                    hash3.Add("9", "because");
                    hash3.Add("10", "they");
                    hash3.Add("11", "keep");
                    hash3.Add("12", "putting");
                    hash3.Add("13", "themselves");
                    hash3.Add("14", "deliberately");
                    hash3.Add("15", "into");
                    hash3.Add("16", "paranoid");
                    hash3.Add("17", "avoidable");
                    hash3.Add("18", "situations");

                    hash3.Remove("17");
                    hash3.Remove("15");

                    string hash40 = hash3.Get("0");
                    Console.WriteLine("0th index value:" + hash40);
                    string hash41 = hash3.Get("1");
                    Console.WriteLine("1th index value:" + hash41);
                    string hash42 = hash3.Get("2");
                    Console.WriteLine("2th index value:" + hash42);
                    string hash43 = hash3.Get("3");
                    Console.WriteLine("3th index value:" + hash43);
                    string hash44 = hash3.Get("4");
                    Console.WriteLine("4th index value:" + hash44);
                    string hash45 = hash3.Get("5");
                    Console.WriteLine("5th index value:" + hash45);
                    string hash46 = hash3.Get("6");
                    Console.WriteLine("6th index value:" + hash46);
                    string hash47 = hash3.Get("7");
                    Console.WriteLine("7th index value:" + hash47);
                    string hash48 = hash3.Get("8");
                    Console.WriteLine("8th index value:" + hash48);
                    string hash49 = hash3.Get("9");
                    Console.WriteLine("9th index value:" + hash49);
                    string hash50 = hash3.Get("10");
                    Console.WriteLine("10th index value:" + hash50);
                    string hash51 = hash3.Get("11");
                    Console.WriteLine("11th index value:" + hash51);
                    string hash52 = hash3.Get("12");
                    Console.WriteLine("12th index value:" + hash52);
                    string hash53 = hash3.Get("13");
                    Console.WriteLine("13th index value:" + hash53);
                    string hash54 = hash3.Get("14");
                    Console.WriteLine("14th index value:" + hash54);
                    string hash55 = hash3.Get("15");
                    Console.WriteLine("15th index value:" + hash55);
                    string hash56 = hash3.Get("16");
                    Console.WriteLine("16th index value:" + hash56);
                    string hash57 = hash3.Get("17");
                    Console.WriteLine("17th index value:" + hash57);
                    string hash58 = hash3.Get("18");
                    Console.WriteLine("18th index value:" + hash58);
                    break;
            }


                    
            Console.ReadKey();
        }
    }
}
