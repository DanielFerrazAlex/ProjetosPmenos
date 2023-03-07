using SistemaEmpresa.Funcionarios;
namespace SistemaEmpresa.Utilitários;
public class GerenciadorDeBonificacao : Diretor
{
    public double TotalDeBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        this.TotalDeBonificacao += funcionario.GetBonificacao();
    }
    public GerenciadorDeBonificacao(string cpf) : base(cpf)
    {
    }
}
