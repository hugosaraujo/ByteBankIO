partial class Program
{
    static void UsarStreamNaConsole()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("dadosConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];
            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                
                fs.Write(buffer, 0, 1024);
                fs.Flush();
                
                Console.WriteLine($"Bytes lidos na console: {bytesLidos}");   
            }
        }
    }
    
}