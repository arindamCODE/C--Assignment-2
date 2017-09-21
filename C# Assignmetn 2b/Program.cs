using System;

namespace C__Assignmetn_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3 = 0;
            Console.WriteLine("Please enter the number upto which you need the Series:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for(int i=0; i<=num; i++)
            {
                n3 = n1+n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
