using System;

namespace Exercise1
{
    abstract class Shape1
    {

        //protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

        public static void Calculate(Shape1 S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }
    }

    class Rectangle : Shape1
    {
        float Length = (float)Convert.ToDouble(Console.ReadLine());
        float Breadth = (float)Convert.ToDouble(Console.ReadLine());
        public override float Area()
        {
            return Length * Breadth;
        }

        public override float Circumference()
        {
            return 2 * Length + 2 * Breadth;
        }

    }

    class Circle : Shape1
    {
        float Radius = (float)Convert.ToDouble(Console.ReadLine());
        public override float Area()
        {
            return (float)Math.PI * Radius * Radius;
        }

        public override float Circumference()
        {
            return 2 * (float)Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length and Breadth(please enter Breadth on next line)");
            Rectangle rec = new Rectangle();
            rec.Area();
            rec.Circumference();
            Shape1.Calculate(rec);

            Console.WriteLine();
            Console.WriteLine("Enter Radius ");
            Circle cir = new Circle();
            cir.Area();
            cir.Circumference();
            Shape1.Calculate(cir);
        }
    }
}
