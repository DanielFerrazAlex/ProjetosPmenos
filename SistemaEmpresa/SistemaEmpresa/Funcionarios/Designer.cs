
namespace SistemaEmpresa.Funcionarios;

public class Designer : Funcionario
{
    public override double GetBonificacao()
    {
        return this.Salario * 0.17;
    }
    public override void AumentarSalario()
    {
        this.Salario *= 1.11;
    }
    public Designer(string cpf) : base(cpf, 3000)
    {

    }
}
