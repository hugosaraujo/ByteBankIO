partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        using (var fluxoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoArquivo);

             
            // var texto = leitor.ReadToEnd();
            // var lerByte = leitor.Read();
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
        Console.Read(); 
    }
}