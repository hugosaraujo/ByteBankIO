using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoArquivo = "contasExportadas.csv";
        using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        {
            var contaString = "456, 7895, 4785.40, Gui Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaString);

            Console.WriteLine("Criando arquivo com conta!");
            fluxoArquivo.Write(bytes, 0, bytes.Length);
        }
    }
    
    static void CriarArquivoComWriter()
    {
        var caminhoArquivo = "contasExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456, 654465,456.0,Pedro");
        }
    }
}