using ByteBank.Titular;

namespace ByteBank.Contas;

public class ContaCorrente : Cliente
{
    public static int TotalContasCriadas { get; private set; }
    public static decimal  Taxa_Operacao { get; private set; }
    private int _Numero_agencia;
    public int Numero_agencia 
    { 
        get 
        {
            return this._Numero_agencia; 
        }
        private set 
        {
            if(value > 0)
            {
                this._Numero_agencia = value;
                
            }
        }
    }
    public string Conta { get; set; }
    public Cliente Titular { get; set; }
    private double Saldo = 0;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
    public bool Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            return true;
        }
        else
        {
            throw new SaldoInsuficienteException("Saque invalido. Saldo Insuficiente!");
        }
    }
    public bool Transferir(double valor, ContaCorrente ContaDestino)
    {
        if (!Sacar(valor))
        {
            throw new SaldoInsuficienteException("Transfêrencia inválida. Saldo insuficiente!");
        }
        Sacar(valor);
        ContaDestino.Depositar(valor);
        return true;
    }
    public void SetSaldo(double valor)
    {
        if(valor < 0)
        {
            return;
        }
        else
        {
            this.Saldo = valor;
        }
    }
    public double GetSaldo()
    {
        return this.Saldo;
    }
    public ContaCorrente(string nome, string cpf, int idade, int numero_agencia, string numero_conta)
    {
        Nome = nome;
        Cpf = cpf;
        Idade = idade;
        Numero_agencia = numero_agencia;
        Conta = numero_conta;
        TotalContasCriadas++;
        if(Numero_agencia <= 0)
        {
            throw new ArgumentException("Número de agencia menor ou igual a zero", nameof(Numero_agencia));
        }
        try
        {
            Taxa_Operacao = 30 / TotalContasCriadas;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não foi possivel realizar a operação.");
        }
    }
}
