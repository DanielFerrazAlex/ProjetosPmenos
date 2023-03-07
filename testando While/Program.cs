using System;
public class Programa {
    static void Main(string[] args){
        int contar = 0;
        string parar;
    
        parar = "run";

        while (parar == "run"){
            Console.WriteLine("Repetindo...");
            contar = contar + 1;

            Console.Write("Digite stop se deseja parar e run se deseja continuar: ");
            parar = Console.ReadLine();

            if (parar == "stop") { 
                Console.WriteLine("O bloco acima NÃO se repetiu mais!!!");
                Console.WriteLine("O bloco repetiu {0} vezes", contar);
                break;
            }
            else if (parar != "stop" || parar != "run") {
                Console.WriteLine("Vc digtou algo errado, tente novamente!!!");
                parar = "run";
                contar = contar - 1;
            }
        }
    }
}