using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//Instanciando os Telefones
Console.WriteLine("Nokia");
Nokia nokia1 = new Nokia("11988899888", "3010", "123123123", 3);
nokia1.Ligar();
nokia1.InstalarAplicativo("Whatsapp");


Console.WriteLine("Iphone");
Iphone iphone1 = new Iphone("11999899899", "11", "456456456", 126);
iphone1.Ligar();
iphone1.InstalarAplicativo("Instagram");
