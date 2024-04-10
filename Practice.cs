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
        System.Console.Write("pos = ");
        int pos = Convert.ToInt32(Console.ReadLine());
        if (pos <= 1 || pos >= n) {
            Console.WriteLine("Invalid pos!");
            return;
        }   
        pos--;
        System.Console.WriteLine("Before inserting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
        for(int i=n/2;i>pos;i--) {
            a[i] = a[i-1];
        }
        a[pos] = num;
        System.Console.WriteLine("\nAfter inserting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
    }
    public static void DeleteArr() {
        System.Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        for(int i=0;i<n;i++) {
            a[i] = i+4;
        }
        System.Console.Write("pos = ");
        int pos = Convert.ToInt32(Console.ReadLine());
        if (pos <= 1 || pos >= n) {
            Console.WriteLine("Invalid pos!");
            return;
        }   
        pos--;
        System.Console.WriteLine("Before deleting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
        for(int i=pos;i<n-1;i++) {
            a[i] = a[i+1];
        }
        a[n-1] = 0;
        System.Console.WriteLine("\nAfter deleting:");
        foreach(int i in a) {
            System.Console.Write(i + " ");
        }
    }
    public static void SumMainDiagonal() {
        int n= Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[n,n];
        Random random = new Random();
        for(int i=0;i<n;i++) {
            for(int j=0;j<n;j++) {
                a[i,j] = random.Next(1,100);
            }
        }
        for(int i=0;i<n;i++) {
            for(int j=0;j<n;j++) {
                Console.Write(a[i,j] + " ");
            }
            Console.WriteLine();
        }
        int sum = 0;
        for(int i=0;i<n;i++) {
            sum+=a[i,i];
        }
        Console.WriteLine(sum);
    } 
    public static void MineSweeperEasy() {
        int[] dx = {-1,0,1,1,1,0,-1,-1};
        int[] dy = {-1,-1,-1,0,1,1,1,0};
        System.Console.Write("Enter the size of the board: ");
        int n = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter mines map: ");
        string[] map = new string[n];
        for(int i=0;i<n;i++) {
#pragma warning disable CS8601 // Possible null reference assignment.
            map[i] = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
        }
        char[,] res = new char[n,n];
        for (int i=0;i<n;i++) {
            for (int j=0;j<n;j++) {
                if (map[i][j] == '*'){
                    res[i,j] = '*';
                    for (int k=0;k<8;k++) {
                        int x = i + dx[k];
                        int y = j + dy[k];
                        if (x >= 0 && x < n && y >= 0 && y < n && res[x,y] != '*') {
                            if (res[x,y] == '\0') res[x,y] = '1'; 
                            else res[x,y]++;
                        }
                    }
                }
                if (res[i,j] == '\0') res[i,j] = '0';
            }
        }
        System.Console.WriteLine("Result: ");
        for (int i=0;i<n;i++) {
            for (int j=0;j<n;j++) {
                Console.Write(res[i,j]);
            }
            Console.WriteLine();
        }
    }
    public static void TemperatureConverter() {
        System.Console.WriteLine("___Temperature Converter___\n1: Celsius to Fahrenheit\n2: Fahrenheit to Celsius\nChoose an option: ");
        int option = Convert.ToInt32(Console.ReadLine());
        double c,f;
        switch(option) {
            case 1:
                System.Console.Write("Enter the temperature in Celsius: ");
                c = Convert.ToDouble(Console.ReadLine());
                f = c * 9 / 5 + 32;
                System.Console.WriteLine("Temperature in Fahrenheit: " + f);
                break;
            case 2:
                System.Console.Write("Enter the temperature in Fahrenheit: ");
                f = Convert.ToDouble(Console.ReadLine());
                c = (f - 32) * 5 / 9;
                System.Console.WriteLine("Temperature in Celsius: " + c);
                break;
            default:
                System.Console.WriteLine("Invalid option!");
                break;
        }
    }
    public static void CountApperance() {
        System.Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Random rand = new Random();
        for(int i=0;i<n;i++) {
            a[i] = rand.Next(1,10);
        }
        int[] count = new int[10];
        for(int i=0;i<n;i++) {
            count[a[i]]++;
        }
        for (int i=1;i<=9;i++) {
            System.Console.WriteLine("Number " + i + " appears " + count[i] + " times");
        }
    }
}