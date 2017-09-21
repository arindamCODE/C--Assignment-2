using System;

namespace C__Assignment_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Array obj = new Array();
            obj.enterSize();
            obj.showArray();
        }
    }

    class Array
    {
        int[] arr;
        int size;
        public void enterSize()
        {
            Console.WriteLine("Please enter the size of your array:");
            size = int.Parse(Console.ReadLine());
            arr = new int[size];
        }

        public void showArray()
        {
            Console.WriteLine("Please enter the array values:");
            for(int i=0; i<size; i++)
            {
               arr[i] = int.Parse(Console.ReadLine());
               if(i==10)
               {
                   Console.WriteLine("You reached 10");
               } 
            }
        }
        
    }
}