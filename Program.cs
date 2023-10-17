namespace MethodsTaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 3;
            int r = 4;
            int a = 5;
            int b = 6;
            int c = 7;

            Console.WriteLine("Area Circle " + Area(p, r));
            Console.WriteLine("Area Rectangular " + Area(a, b));
            Console.WriteLine("Area Rectangular parallelepiped " + Area(a, b, c));
            Console.WriteLine("Area Circle inscribed in a triangle " + Area(a, b, c, r));
        }


        static int Area(int p, int r)
        {
            return p * (r * r);
        }
        static int Area(int a, int b)
        {
            return a * b;
        }
        static int Area(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        static int Area(int a, int b, int c, int r)
        {
            return ((a + b + c) / 2) * 2;
        }
    }
}