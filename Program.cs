using DesafioPOO.Models;

Console.WriteLine("smartphone Nokia: ");

Nokia NK= new Nokia(numero: "4646340", modelo: "Modelo:521 ", Imei: "1221122", memoria: 256);
NK.Ligar();
NK.InstalarAplicativo("Instagram");

Console.WriteLine("/n");

Console.WriteLine("Smatphone Iphone");
Iphone Iph = new Iphone(numero: "6475878", modelo: "Modelo:347 ", Imei: "46466578", memoria: 256);
Iph.ReceberLigacao();
Iph.InstalarAplicativo("Telegram");