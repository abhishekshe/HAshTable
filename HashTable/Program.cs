using System;
using System.Collections.Generic;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table");
           
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
           
            string words = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
           
            string[] arr = words.Split(" ");
            
            LinkedList<string> checkForDuplication = new LinkedList<string>();
           
            foreach (string element in arr)
            {
               
                int count = 0;
                
                foreach (string match in arr)
                {
                    if (element == match)
                    {
                        count++;
                      
                        if (checkForDuplication.Contains(element))
                        {
                            break;
                        }
                    }

                }
               
                if (checkForDuplication.Contains(element))
                {
                    continue;
                }
               
                checkForDuplication.AddLast(element);
                
                hash.Add(element, count);
            }
            
            int frequency = hash.Get("Paranoids");
            Console.WriteLine("frequency for Paranoids:\t" + frequency);

            
            Console.WriteLine("****************");
            Console.WriteLine("Displaying all the key value pairs in hash table");
            hash.Display();

        }
    }
}