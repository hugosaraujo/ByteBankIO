using System.Text;
using ByteBankIO.Modelos;

partial class Program
{
    public void LidandoComFiles()
    {
        var enderecoArquivo = "contas.txt";

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;
            var buffer = new byte[1024];
    
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);

                Console.WriteLine($"\nbytes lidos, {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);    
            }
            fluxoArquivo.Close();
        }
    }
    
    public static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
    }
    

}