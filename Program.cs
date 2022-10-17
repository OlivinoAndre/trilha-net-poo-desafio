using DesafioPOO.Models;

Smartphone smart1 = new Nokia(numero: "(11) 91111-1111", modelo: "Modelo 1", imei: "11111111111111", memoria: 64);
Smartphone smart2 = new Iphone(numero: "(11) 91111-1112", modelo: "Modelo 2", imei: "2222222222222", memoria: 128);

Console.WriteLine(smart1);
smart1.Ligar();
smart1.ReceberLigacao();
smart1.InstalarAplicativo("Dio");

Console.WriteLine(smart2);
smart2.Ligar();
smart2.ReceberLigacao();
smart2.InstalarAplicativo("Dio Plus");
smart2.Numero = "(11) 91111-1112";
Console.WriteLine(smart2);