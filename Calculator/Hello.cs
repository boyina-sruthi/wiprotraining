using System;

namespace HelloOperations
{
    class Program1
    {
        public static void Main(string[] args)
        {


            int a = 20;
            int b = 10;
            var i = 10;
            var v = "Hello";
            string s = "Hello";
            char ch = 'B';
            Console.WriteLine("enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second Number : ");
            b = Convert.ToInt16(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("The result is : " + result);
            Console.WriteLine("The size Of char is : " + sizeof(char));
            Console.WriteLine("The Data type of i is : " + i.GetType());
            Console.WriteLine("The Data type of v is : " + v.GetType());

        
        }

    }
}