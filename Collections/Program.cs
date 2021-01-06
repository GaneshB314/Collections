using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");

            ArrayList al = new ArrayList(5);
            Console.WriteLine(" The Capacity of ArrayList is " + al.Capacity);
            al.Add(100);
            al.Add("Ganesh");
            al.Add(53.5);
            al.Add('B');
            al.Add(52.354);
            al.Add(52);

            foreach (var item in al)
            {
                Console.WriteLine("The Items are" + item);
             

            }
            Console.WriteLine(" The Capacity of ArrayList after Increasing is " + al.Capacity);
            al.RemoveAt(0);
            Console.WriteLine(" The Capacity of ArrayList after Decreasing is " + al.Capacity);
            al.Add(100);
            al.Add("Ganesh");
            al.Add(53.5);
            al.Add('B');
            al.Add(52.354);
            al.Add(52);
            Console.WriteLine(" The Capacity of ArrayList after Increasing next 10 is " + al.Capacity);


             

        }
    }
}
