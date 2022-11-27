using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine();
Smartphone nokia = new Nokia(numero:"12345",modelo:"Android",imei:"1112333445",memoria:20);
nokia.Ligar();
nokia.InstalarAplicativo("Aplicativo android");
Console.WriteLine("\n");
Console.WriteLine();
Smartphone Iphone = new Iphone(numero:"67891", modelo:"Apple",imei:"2222222",memoria:30);
Iphone.Ligar();
Iphone.InstalarAplicativo("Aplicativo apple");