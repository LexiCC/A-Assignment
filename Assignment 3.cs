using System;
namespace CSharpAssignment
{
    public class Assignment_3
    {
        //---------------------------------------------------------------------1. Reverse Array
        public static int[] GenerateNumbers()
        {
            int Min = 1;
            int Max = 25;
            int[] res = new int[8];

            Random randNum = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = randNum.Next(Min, Max);
            }
            return res;
        }

        public static void Reverse(int[] input)
        {
            int i = 0;
            int j = input.Length - 1;

            while (i < j)
            {
                int tmp = input[i];
                input[i] = input[j];
                input[j] = tmp;
                i++;
                j--;
            }
        }

        public static void PrintNumbers(int[] input)
        {
            foreach(int num in input){
                Console.Write(num + " ");
            }
           
        }

        //---------------------------------------------------------------------2. Fibonacci
        public static int Fibonacci(int k)
        {
            //base case
            if(k < 0)
            {
                return 0;
            }

            if (k == 1 || k == 0)
            {
                return k;
            }

            return Fibonacci(k - 2) + Fibonacci(k - 1);
        }

        //static void Main(string[] args) {
        //    int[] numbers = GenerateNumbers();
        //    Reverse(numbers);
        //    PrintNumbers(numbers);

        //    Console.Write(Fibonacci(8));
        //}
    }
}
