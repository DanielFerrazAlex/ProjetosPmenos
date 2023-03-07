using System;
public class Programa {
    static void Main(string[] args) {
        float num1, num2, result;
        string operador;
        bool flag = true;

        while (flag){
            Console.WriteLine("Escolha uma das opções abaixo:\n1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-sair");
            Console.Write("Digite qual operação voçes irá utilizar: ");
            operador = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());

            if (operador == "1"){
                result = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            }
            else if (operador == "2"){
                result = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
            }
            else if (operador == "3"){
                result = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            }
            else if (operador == "4"){
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            else if (operador == "5"){
                flag = false;
                break;
            }
            else {
                Console.WriteLine("Escolha invalida, tente novamente!!");
            }
        }
    }
}