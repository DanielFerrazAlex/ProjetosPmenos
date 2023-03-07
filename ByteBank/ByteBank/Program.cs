using ByteBank;
using ByteBank.Contas;
using System.Numerics;

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida!");
}
finally
{
    leitor.Dispose();
}

//try
//{
//    ContaCorrente conta1 = new ContaCorrente("Daniel Ferraz", "054.012.492-33", 23, 276, "1010-X");
//    conta1.Depositar(100);
//    Console.WriteLine(conta1.GetSaldo());
//    conta1.Sacar(10);
//    Console.WriteLine(conta1.GetSaldo());
//    conta1.Sacar(150);
//    Console.WriteLine(conta1.GetSaldo());
//}
//catch (ArgumentException Error)
//{
//    Console.WriteLine("Parâmetro com erro: " + Error.ParamName);
//    Console.WriteLine("Não é possivel criar uma conta, com o número da agência é menor que zero!");
//    Console.WriteLine(Error.StackTrace);
//    Console.WriteLine(Error.Message);
//}
//catch(SaldoInsuficienteException Error)
//{
//    Console.WriteLine("Operação negada. Saldo Insuficiente!");
//    Console.WriteLine(Error.Message);
//}

//ContaCorrente conta2 = new ContaCorrente("Caio Viana", "567.452.242-21", 24, 842, "1851-Y");

//Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalContasCriadas);
//Console.WriteLine("Taxa de operação: " + ContaCorrente.Taxa_Operacao);
//Console.ReadLine();