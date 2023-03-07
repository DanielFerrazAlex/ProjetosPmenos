
namespace SistemaEmpresa.Funcionarios;

public class Gerente_Contas : Funcionario
{
    public override double GetBonificacao()
    {
        return this.Salario * 0.25;
    }
    public override void AumentarSalario()
    {
        this.Salario *= 1.05;
    }
    public Gerente_Contas(string cpf) : base(cpf, 4000)
    {
    }
}
