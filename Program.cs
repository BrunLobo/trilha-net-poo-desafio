using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Nokia nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);

        nokia.InstalarAplicativo("Facebook");
        nokia.Ligar();

        Console.WriteLine("\n");

        // Testando a classe Iphone
        Iphone iphone = new Iphone(numero: "456789", modelo: "Modelo 2", imei: "22222", memoria: 64);

        iphone.InstalarAplicativo("WhatsApp");
        iphone.ReceberLigacao();
    }
}
