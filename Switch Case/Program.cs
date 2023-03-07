using System;
public class Programa
{
    static int som(int num1, int num2)
    {
        return num1 + num2;
    }
    static int sub(int num1, int num2)
    {
        return num1 - num2;
    }
    static int mul(int num1, int num2)
    {
        return num1 * num2;
    }
    static int div(int num1, int num2)
    {
        return num1 / num2;
    }
    static void Main()
    {
        int num1, num2, opd;

        Console.WriteLine("Escolha uma das opções digitando o número correspondente:\n1-soma\n2-subtração\n3-multiplicação\n4-divisão");
        opd = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());

        switch (opd)
        {
            case 1:
                Console.WriteLine(som(num1, num2));
                break;
            case 2:
                Console.WriteLine(sub(num1, num2));
                break;
            case 3:
                Console.WriteLine(mul(num1, num2));
                break;
            case 4:
                Console.WriteLine(div(num1, num2));
                break;
            default:
                Console.WriteLine("Opção Invalida!");
                break;
        }
    }
}
