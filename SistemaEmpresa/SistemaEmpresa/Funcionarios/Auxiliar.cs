
namespace SistemaEmpresa.Funcionarios;

public class Auxiliar : Funcionario
{
    public override double GetBonificacao()
    {
        return this.Salario * 0.20;
    }
    public override void AumentarSalario()
    {
        this.Salario *= 1.10;
    }
    public Auxiliar(string cpf) : base(cpf, 2000)
    {
    }
}
