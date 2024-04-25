// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static void MergeSort(int[] arr)
    {
        int n = arr.Length;
        if (n < 2)
        {
            return;
        }
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];
        for (int i = 0; i < mid; i++)
        {
            left[i] = arr[i];
        }
        for (int i = mid; i < n; i++)
        {
            right[i - mid] = arr[i];
        }
        MergeSort(left);
        MergeSort(right);
        Merge(left, right, arr);
    }
    static void Merge(int[] left, int[] right, int[] arr)
    {
        int nL = left.Length;
        int nR = right.Length;
        int i = 0, j = 0, k = 0;
        while (i < nL && j < nR)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        while (i < nL)
        {
            arr[k] = left[i];
            i++;
            k++;
        }
        while (j < nR)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
    private static void Main(string[] args)
    {
        // SnakeGame game = new SnakeGame();
        // game.Run();


        // Animal cat = new Cat("20kg", "1.5", "kitty");
        // cat.PrintInfo();
        // System.Console.WriteLine();
        // cat = new Kitten("10kg", "1", "kitty", 2);
        // cat.PrintInfo();

        int[] arr = new int[100000];
        Random rand = new Random();
        for (int i = 0; i < 100000; i++)
        {
            arr[i] = rand.Next(1, 10000);
        }
        StopWatch sw = new StopWatch();
        sw.Start();
        MergeSort(arr);
        sw.Stop();
        sw.GetElapsedTime();
    }
}