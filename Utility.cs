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
    public static void MultiTable()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} * {1} = {2}\t", j, i, i * j);
            }
            Console.WriteLine();
        }
    }
    public static void Prime() {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n%2==0&&n!=2 || n==1) {
            Console.WriteLine("Not a prime!");
            return;
        }
        for(int i=3;i<=Math.Sqrt(n);i+=2){
            if(n%i==0) {
                Console.WriteLine("Not a prime!");
                return;
            }
        }
        Console.WriteLine("A prime!");
        return;
    }
}