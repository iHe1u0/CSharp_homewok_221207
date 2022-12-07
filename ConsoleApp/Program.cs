using ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Number x, y;
        Console.WriteLine("Please input the real number 1:");
        x = new Real(double.Parse(Console.ReadLine()));
        Console.WriteLine("Please input the real number 2:");
        y = new Real(double.Parse(Console.ReadLine()));
        Console.WriteLine("{0}+{1}={2}", x.Value, y.Value, ((Operation)x).Add(y).Value);
        Console.WriteLine("{0}-{1}={2}", x.Value, y.Value, ((Operation)x).Subtract(y).Value);
        Console.WriteLine("{0}*{1}={2}", x.Value, y.Value, ((Operation)x).Multiply(y).Value);
        Console.WriteLine("{0}/{1}={2}", x.Value, y.Value, ((Operation)x).Divide(y).Value);

        Console.WriteLine("Please input the real part of complex number 1:");
        double a1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input the imaginary part of complex number 1:");
        double b1 = double.Parse(Console.ReadLine());
        x = new Complex(a1, b1);
        Console.WriteLine("Please input the real part of complex number 2:");
        double a2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please input the imaginary part of complex number 2:");
        double b2 = double.Parse(Console.ReadLine());
        y = new Complex(a2, b2);
        Console.WriteLine("{0}+{1}={2}", x.Value, y.Value, ((Operation)x).Add(y).Value);
        Console.WriteLine("{0}-{1}={2}", x.Value, y.Value, ((Operation)x).Subtract(y).Value);
        Console.WriteLine("{0}*{1}={2}", x.Value, y.Value, ((Operation)x).Multiply(y).Value);
        Console.WriteLine("{0}/{1}={2}", x.Value, y.Value, ((Operation)x).Divide(y).Value);
        Console.ReadKey();
    }
}