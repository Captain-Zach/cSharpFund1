using System;
using System.Collections.Generic;

namespace MakePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            for (int i = 0; i <=100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("Can't do both");
                } else if(i % 3 == 0){
                    Console.WriteLine(i);
                } else if(i % 5 == 0){
                    Console.WriteLine(i);
                }
            }
            for (int i = 0; i <=100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                } else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                } else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
            }
            coll_practice();

        }
        static void coll_practice(){
            // arrays
            int[] oneThrough = new int[] {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] flips = new bool[10];
            for(int i = 0; i < flips.Length; i++){
                if(i % 2 == 0){
                    flips[i] = true;
                }else{
                    flips[i] = false;
                }
            }
            List<string> iceCream = new List<string>();
            iceCream.Add("Dookie");
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Strawberry");
            iceCream.Add("Gun");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove(iceCream[2]);
            Console.WriteLine(iceCream.Count);

            Dictionary<string,string> strange = new Dictionary<string,string>();
            for(int i = 0; i < names.Length; i++){
                strange.Add(names[i], iceCream[i]);
                Console.WriteLine(i);

            }
            Console.WriteLine(strange);
            foreach(var entry in strange){
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }
        }
    }
}
