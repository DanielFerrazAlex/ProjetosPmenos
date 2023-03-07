namespace program;

class program 
{
    public static void Main(string[] args)
    {
        int a, b, c;

        Console.Write("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        c = int.Parse(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);
        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (delta < 0)
        {
            Console.WriteLine("Delta é menor que 0");
            Console.WriteLine($"Valor de Delta: {delta}");
        }
        else
        {
            Console.WriteLine($"Valor de Delta: {delta}");
            Console.WriteLine($"Valor de x1: {x1}");
            Console.WriteLine($"Valor de x2: {x2}");

        }
    }
}
