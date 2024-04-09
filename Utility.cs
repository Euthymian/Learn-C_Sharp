static class Practice
{
    public static void Linear()
    {
        System.Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Infinite solutions");
            }
            else
            {
                Console.WriteLine("No solution");
            }
        }
        else
        {
            Console.WriteLine("Solution of {0}x + {1} = 0 is {2}",a,b,(double)-b / a);
        }
    }   

    public static void GetSystemTime() {
        Console.WriteLine(DateTime.Now);
    }
}