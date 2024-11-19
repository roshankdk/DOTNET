// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Hello, World!");

class Program
{
    public static void Main(String[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("This is the line " + i);
        }


        int[] num = { 12, 13, 14, 15, 16, 17, 18 };

        for (int i = 0; i <= 5; i++)
        {
            Console.Write(num[i] + " ");
        }

        foreach(int i in num){
            Console.Write(i+" ");
        }
        
        for(int i= 0; i<num.Length; i++){
            Console.Write(num[i] + " ");
        }
    }
}
