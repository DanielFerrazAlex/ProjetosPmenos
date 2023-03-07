using SistemaEmpresa.Funcionarios;
using SistemaEmpresa.Utilitários;

Funcionario Daniel = new Funcionario("054.012.492-33", 1200.25);
Daniel.Nome = "Daniel Ferraz";
Daniel.Matricula = "12515189";


Console.WriteLine($"Nome do Funcionario: {Daniel.Nome}");
Console.WriteLine($"CPF do Funcionario {Daniel.CPF}");
Console.WriteLine($"Matricula do Funcionario: {Daniel.Matricula}");
Console.WriteLine($"Salario do Funcionario: {String.Format("{0:0.00}", Daniel.Salario)}");
Console.WriteLine($"Bonificação: {Daniel.GetBonificacao()}\n");

Diretor Caio = new Diretor("156.195.815-21");
Caio.Nome = "Caio Viana";
Caio.Matricula = "84115458";

Console.WriteLine($"Nome do Funcionario: {Caio.Nome}");
Console.WriteLine($"CPF do Funcionario {Caio.CPF}");
Console.WriteLine($"Matricula do Funcionario: {Caio.Matricula}");
Console.WriteLine($"Salario do Funcionario: {String.Format("{0:0.00}", Caio.Salario)}");
Console.WriteLine($"Bonificação: {Caio.GetBonificacao()}\n");

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("74581");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
}


Console.WriteLine($"total de bonificacçes: {String.Format("{0:0.00}", CalcularBonificacao)}");
Console.WriteLine($"Total de Funcionários:  {Funcionario.TotalFuncionarios}");