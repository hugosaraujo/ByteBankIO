namespace ByteBankIO.Modelos;

public class ContaCorrente
{
    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;
    }
    
    public int Numero { get; }
    public int Agencia { get; }
    public double Saldo { get; set; }
    public Cliente Cliente { get; set; }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de depósito precisa ser maior que zero.", nameof(valor));
        }

        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor de depósito precisa ser maior que zero.", nameof(valor));
        }

        if (valor > Saldo)
        {
            throw new ArgumentException("O valor de saque não pode ser maior que o valor em conta.", nameof(valor));
        }

        Saldo -= valor; 
    }
}