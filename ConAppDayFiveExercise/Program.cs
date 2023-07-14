using System;
using System.Collections;

namespace ConAppDayFiveExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an ArrayList
            ArrayList fruits = new ArrayList();

            //Add elements to the ArrayliSt
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            //print the total number of elements in the ArrayList
            int totalElements = fruits.Count;
            Console.WriteLine("Total number of ELements: "+totalElements);

            //print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList: ");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //check if the ArrayList contains the element "date" and print the result
            string searchItem = "date";
            bool containsItem = fruits.Contains(searchItem);
            Console.WriteLine($"\nDoes the ArrayList contain '{searchItem}'?{containsItem}");

            //Insert the element "g" at the second position in the ArrayList
            fruits.Insert(1, "g");
            Console.WriteLine("After inserting 'g' at index 1: ");
            foreach(string fruit in fruits) 
            { 
                Console.WriteLine(fruit); 
            }

            //Remove the element "banana" from the ArrayList
            fruits.Remove("banana");
            Console.WriteLine("\nAfter removing 'banana': ");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }
    }
}
