using ByteBankIO.Modelos;

partial class Program
{
    public void UtilizandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoArquivo);
            
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterParaContaCorrente(linha!);
                string msg = 
                    $"Agência: {contaCorrente.Numero}, " +
                    $"Nº Conta: {contaCorrente.Numero}, " +
                    $"Saldo: {contaCorrente.Saldo} " +
                    $"-> Titular: {contaCorrente.Titular.Nome}";
                
                Console.WriteLine(msg);
            }
        }
    }
    static ContaCorrente ConverterParaContaCorrente(string linha)
    {
        // 332 1223 1833.99 Josiane
        var campos = linha.Split(",");

        var agencia = int.Parse(campos[0]);
        var numeroConta = int.Parse(campos[1]);
        var saldoComoDouble = double.Parse(campos[2].Replace(".", ","));

        Cliente titular = new Cliente();
        titular.Nome = campos[3];
        
        var resultado = new ContaCorrente(agencia, numeroConta);
        resultado.Depositar(saldoComoDouble);
        resultado.Titular = titular;

        return resultado; 
    }
}