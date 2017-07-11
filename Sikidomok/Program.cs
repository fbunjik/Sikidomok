using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            do
            {
                Console.Clear();
                Console.WriteLine("Kerület-Terület kiszámító program!");
                Console.WriteLine("Kérem válasszon!");
                Console.WriteLine("[1] Négyzet");
                Console.WriteLine("[2] Téglalap");
                Console.WriteLine("[3] Kör");
                Console.WriteLine("[4] Háromszög");
                Console.WriteLine("[5] Kilépés");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Add meg a Négyzet paramétereit.");
                        Console.Write("A oldal:");
                        var square = new Square(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Kerület: {square.District()}");
                        Console.WriteLine($"Terület: {square.Area()}");
                        Console.Write("Nyomj egy ENTER-t!");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Add meg a Téglalap paramétereit.");
                        Console.Write("A oldal:");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("B oldal:");
                        double b = double.Parse(Console.ReadLine());
                        var rectangle = new Rectangle(a, b);
                        Console.WriteLine($"Kerület: {rectangle.District()}");
                        Console.WriteLine($"Terület: {rectangle.Area()}");
                        Console.Write("Nyomj egy ENTER-t!");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Add meg a Kör paramétereit.");
                        Console.Write("Sugár:");
                        var round = new Round(double.Parse(Console.ReadLine()));
                        Console.WriteLine($"Kerület: {round.District()}");
                        Console.WriteLine($"Terület: {round.Area()}");
                        Console.Write("Nyomj egy ENTER-t!");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Add meg a Háromszög paramétereit.");
                        Console.Write("A oldal:");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("B oldal:");
                        double y = double.Parse(Console.ReadLine());
                        Console.Write("C oldal:");
                        double c = double.Parse(Console.ReadLine());
                        var triangle = new Triangle (x,y,c);
                        Console.WriteLine($"Kerület: {triangle.District()}");
                        Console.WriteLine($"Terület: {triangle.Area()}");
                        Console.Write("Nyomj egy ENTER-t!");
                        Console.ReadLine();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hibás Paraméter!");
                        Console.Write("Nyomj egy ENTER-t!");
                        Console.ReadLine();
                        break;
                }

            } while (true);
        }
    }

    abstract class PlaneFigure
    {
        abstract public double District();
        abstract public double Area();
    }

    abstract class Quadrilateral:PlaneFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Quadrilateral(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

    }

    class Round : PlaneFigure
    {
        public double Radius { get; set; }
        public Round(double radius)
        {
            Radius = radius;
        }

        public override double District()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
        class Triangle : PlaneFigure
        {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }
            public override double District()
            {
                return A + B + C;
            }

            public override double Area()
            {
                return A * B / 2;
            }
        }

        class Rectangle: Quadrilateral
        {
            public Rectangle(double a, double b)
                :base(a,b,a,b)
            {

            }

            public override double District()
            {
                return A + B + C + D;
            }

            public override double Area()
            {
                return A * B;
            }
        }

        class Square : Rectangle
        {
            public Square(double a)
                :base(a,a)
            {

            }

            public override double District()
            {
                return 4 * A;
            }
            public override double Area()
            {
                return A * A;
            }
        }

    }


