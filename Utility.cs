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
    public static void SumArr() {
        int[] a = {1,2,3,4,5};
        int sum = 0;
        foreach(int i in a) {
            sum+=i;
        }
        Console.WriteLine(sum);
    }
    public static void FindStudent() {
        string[] students = {"John", "Jane", "Doe", "Smith", "Alex", "Johan", "Dinh", "Haa"};
        string? studentIn = Console.ReadLine();
        foreach(string student in students) {
            if(studentIn==student) {
                Console.WriteLine("Found!");
                return;
            }
        }
        Console.WriteLine("Not found!");
    }
    public static void MaxArr() {
        int[] a = {1,2,3,4,5};
        int max = a[0];
        foreach(int i in a) {
            if(i>max) {
                max = i;
            }
        }
        Console.WriteLine(max);
    }
    public static void InsertArr() {
        System.Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for(int i=0;i<n/2;i++) {
            a[i] = i+4;
        }
        System.Console.Write("num = ");
        int num = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("index = ");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index <= 1 || index >= n) {
            Console.WriteLine("Invalid index!");
            return;
        }   
        index--;
        System.Console.WriteLine("Before inserting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
        for(int i=n/2;i>index;i--) {
            a[i] = a[i-1];
        }
        a[index] = num;
        System.Console.WriteLine("\nAfter inserting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
    }
}