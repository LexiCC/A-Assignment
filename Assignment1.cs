using System;
namespace CSharpAssignment
{
    public class Assignment1
    {
         public void p1()
        {
            //---------------------------------------------------------------------- Problem 1
            Console.WriteLine("Minimum value of sbyte: " + sbyte.MinValue);
            Console.WriteLine("Maximum value of sbyte: " + sbyte.MaxValue);
            Console.WriteLine("Minimum value of byte: " + byte.MinValue);
            Console.WriteLine("Maximum value of byte: " + byte.MaxValue);

            Console.WriteLine("Minimum value of short: " + short.MinValue);
            Console.WriteLine("Maximum value of short: " + short.MaxValue);

            Console.WriteLine("Minimum value of ushort: " + ushort.MinValue);
            Console.WriteLine("Maximum value of ushort: " + ushort.MaxValue);

            Console.WriteLine("Minimum value of int: " + int.MinValue);
            Console.WriteLine("Maximum value of int: " + int.MaxValue);

            Console.WriteLine("Minimum value of uint: " + uint.MinValue);
            Console.WriteLine("Maximum value of uint: " + uint.MaxValue);

            Console.WriteLine("Minimum value of long: " + long.MinValue);
            Console.WriteLine("Maximum value of long: " + long.MaxValue);

            Console.WriteLine("Minimum value of ulong: " + ulong.MinValue);
            Console.WriteLine("Maximum value of ulong: " + ulong.MaxValue);

            Console.WriteLine("Minimum value of float: " + float.MinValue);
            Console.WriteLine("Maximum value of float: " + float.MaxValue);

            Console.WriteLine("Minimum value of double: " + double.MinValue);
            Console.WriteLine("Maximum value of double: " + double.MaxValue);

            Console.WriteLine("Minimum value of decimal: " + decimal.MinValue);
            Console.WriteLine("Maximum value of decimal: " + decimal.MaxValue);
        }

        public void p2()
        {
            //-------------------------------------------------------------------------- Problem 2
            Console.Write("Enter a century: ");
            int century = Convert.ToInt32(Console.ReadLine());
        int years = century * 100;
        int days = years * 365;
        int hours = checked(days * 24);
        int minutes = checked(hours * 60);
        int seconds = checked(minutes * 60);
        int milliseconds = checked(seconds * 1000);
        int microseconds = checked(milliseconds * 1000);
        int nanoseconds = checked(microseconds * 1000);

        Console.WriteLine("Input: ", century);
            Console.WriteLine($"Output: {century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes " +
                $"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanosecond");
        }

        public void FizzBuzz()
        {
            //----------------------------------------------------------------- 1.FizzBuzz
            Console.WriteLine("Enter a number between 1 ~ 100: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input <= 100 && input > 0)
            {
                if (input % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (input % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (input % 3 == 0 && input % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                input--;
            }//end while loop 
        }

        public void PrintPyramid()
        {
            //------------------------------------------------------------------ 2.Print-a-Pyramid
            Console.WriteLine("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int k = 0;

            for (int i = 1; i <= rows; ++i, k = 0)
            {
                for (int space = 1; space <= rows - i; ++space)
                {
                    Console.Write("  ");
                }
                while (k != 2 * i - 1)
                {
                    Console.Write("* ");
                    ++k;
                }
                Console.WriteLine(" ");
            }
        }

        public void GuessNum()
        {
            //------------------------------------------------------------------ 3.Guess Number
            Console.WriteLine("Guess a number between 1 and 3: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            int correctNumber = new Random().Next(3) + 1;

            if (guessedNumber == correctNumber)
            {
                Console.Write("You got the correct number");
            }
            else if (guessedNumber < correctNumber && guessedNumber >= 1)
            {
                Console.Write("The number you guessed is lower than correct number");
            }
            else if (guessedNumber > correctNumber && guessedNumber <= 3)
            {
                Console.Write("The number you guessed is higher than correct number");
            }
            else
            {
                Console.Write("Not valid, outside of the range");
            }
        }

        public void birthday()
        {
            //------------------------------------------------------------------ 4.Birthday Days
            int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int birthday_year = 1995;
            int birthday_month = 5;
            int birthday_date = 15;

            int current_year = 2022;
            int current_month = 3;
            int current_date = 15;

            if (birthday_month > current_month)
            {
                current_month = current_month - 1;

                current_date = current_date
                          + month[birthday_month - 1];
            }
            if (birthday_month > current_month)
            {
                current_year = current_year - 1;
                current_month = current_month + 12;
            }

            int calculated_month = current_month - birthday_month;
            int calculated_date = current_date - birthday_date + (current_year - birthday_year) * 365
                + calculated_month * 30;

            Console.WriteLine(calculated_date + " days");
        }

        public void Greetting()
        {
            //------------------------------------------------------------------ 5.Greetting users
            TimeSpan Morning_start = new TimeSpan(6, 0, 0); //7 o'clock
            TimeSpan Morning_end = new TimeSpan(12, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now >= Morning_start) && (now <= Morning_end))
            {
                Console.WriteLine("Good Morning!");
            }

            TimeSpan Noon_start = new TimeSpan(13, 0, 0); //1pm o'clock
            TimeSpan Noon_end = new TimeSpan(19, 0, 0); //7pm o'clock

            if ((now >= Noon_start) && (now <= Noon_end))
            {
                Console.WriteLine("Good Afternoon!");
            }

            TimeSpan eve_start = new TimeSpan(20, 0, 0);
            TimeSpan eve_end = new TimeSpan(0, 0, 0);

            if ((now >= eve_start) && (now <= eve_end))
            {
                Console.WriteLine("Good Evening!");
            }

            TimeSpan night_start = new TimeSpan(1, 0, 0);
            TimeSpan night_end = new TimeSpan(5, 0, 0);

            if ((now >= eve_start) && (now <= eve_end))
            {
                Console.WriteLine("Good Night!");
            }
        }

        public void Count24()
        {
            //------------------------------------------------------------------ 6.counting up to 24
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 24; j = j + i)
                {
                    Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}

