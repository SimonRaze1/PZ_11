namespace PZ_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 45;
            double c = 125;
            double d = 245;
            double AMeanAB, GMeanAB;
            double AMeanAC, GMeanAC;
            double AMeanAD, GMeanAD;
            Mean(a, b, out AMeanAB, out GMeanAB);
            Mean(a, c, out AMeanAC, out GMeanAC);
            Mean(a, d, out AMeanAD, out GMeanAD);
            Console.WriteLine("Средние значения: Арифметическое - " + AMeanAB + ", и геометрическое - " + GMeanAB);
            Console.WriteLine("Средние значения: Арифметическое - " + AMeanAC + ", и геометрическое - " + GMeanAC);
            Console.WriteLine("Средние значения: Арифметическое - " + AMeanAD + ", и геометрическое - " + GMeanAD);
        }
        static void Mean(double x, double y, out double AMean, out double GMean)
            {
                AMean = (x + y) / 2;
                GMean = Math.Sqrt(x * y);
            }
    }
}