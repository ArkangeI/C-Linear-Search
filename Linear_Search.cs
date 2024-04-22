using System;

class Linear_Search
{
    public static void Main(string[] args)
    {
        bool found = false;
        int[] num = new int[10];


        Console.WriteLine("Please enter " + num.Length + " numbers");
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nWhat is the target number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == x)
            {
                found = true;
            }
        }


        if (found)
        {
            Console.WriteLine("\nThe target is in the set.");
        }
        else
        {
            Console.WriteLine("The target is not in the set.");
        }
    }
}
