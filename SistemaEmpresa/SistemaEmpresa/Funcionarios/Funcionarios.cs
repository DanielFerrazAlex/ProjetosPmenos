namespace SistemaEmpresa.Funcionarios;
public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public string Matricula { get; set; }
    public static int TotalFuncionarios { get; private set; }
    public double Salario { get; protected set; }

    public virtual double GetBonificacao()
    {
        return this.Salario * 0.10;
    }
    public Funcionario(string cpf, double salario)
    {
        this.Salario = salario;
        this.CPF = cpf;
        TotalFuncionarios++;
    }
    public virtual void AumentarSalario()
    {
        this.Salario *= 1.10;
    }
}

