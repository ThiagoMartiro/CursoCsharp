﻿namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.WriteLine("Digite um numero:");
            final = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<=final ;i++)
            {
                if(i%2==0)
                {
                    Console.Write(" {0}",i);
                }
            }
        }   
    }
}
