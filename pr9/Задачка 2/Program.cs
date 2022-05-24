// See https://aka.ms/new-console-template for more information

using System;
 
class Program
{
    static void Main(string[] args)
    {
        const int N = 50;
        int[] arr = new int[N];

        var rand = new Random();
        for (int i = 0; i < N; i++) arr[i] = rand.Next(0, 51);

        int nullElem = 0;
        for (int i = 0; i < N; i++)
            if (arr[i] == 0) nullElem++;

        int j = 0;
        int[] newArr = new int[N - nullElem];
        for (int i = 0; i < N; i++)
            if (arr[i] != 0) newArr[j++] = i;
    }
}
