using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();

Console.WriteLine("Smartphone NOKIA");
Smartphone nokia = new Nokia(numero: "99999999", modelo: "NOKIA Windows phone", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine(" Iphone ");
Smartphone iphone = new Iphone(numero: "0000000", modelo: "15 Pro Max", imei: "12345678", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");