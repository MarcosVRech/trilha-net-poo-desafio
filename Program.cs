using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "1111111111", memoria: 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Testando iPhone:");
        Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 13", imei: "2222222222", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}