using System;
namespace CSharpAssignment
{
    public class Color
    {
        private int red;
        private int blue;
        private int green;
        private int alpha;

        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int blue, int green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }

        public Color(int red, int blue, int green, int alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = 255;
        }

        public int grayscale(int red, int blue, int green)
        {
            return (red + blue + green) / 3;
        }
    }// end of Color

    public class Ball
    {
        private double size;
        private int count;
        private Color mycolor = new Color(0, 255, 0);

        public double Size { get; set; }
        public int Count { get; set; }

        public Ball(double size)
        {
            Size = size;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                Count++;
            }
            else
            {
                return;
            }
        }

        public int thrownTimes()
        {
            return Count;
        }
    }//end of Ball

     public class test
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball(5); //a ball with size 5
            b1.Count = 10; //set initial thrown times to be 10
            b1.Pop(); // pop ball
            b1.Throw(); // thrown ball
            Console.WriteLine(b1.thrownTimes());

            Ball b2 = new Ball(5); //a ball with size 5
            b2.Count = 10; //set initial thrown times to be 10
            b2.Throw(); // thrown ball
            b2.Throw();
            Console.WriteLine(b2.thrownTimes());
        }
    }
}