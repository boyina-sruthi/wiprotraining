using System;
class Data
{
    static void Main()
    {
        short number1 = 45;
        System.Int16 x1 = 33;

        int x = 40;
        System.Int32 x2 = 45;

        Console.WriteLine(x.GetType());


    }
    public uint AddOperations(int a, int b)
     {
        uint result = (uint) (a + b);
        return result;
    }

}