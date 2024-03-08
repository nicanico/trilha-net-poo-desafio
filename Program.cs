using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia modeloNokia = new Nokia("1111-1111", "6546457", "C10", "20gb");
modeloNokia.InstalarAplicativo("Whatsapp");
modeloNokia.ReceberLigacao();
modeloNokia.Ligar();

Iphone modeloPhone = new Iphone("1111-1111", "65765135", "15 Pro Max", "256gb");
modeloPhone.InstalarAplicativo("Instagram");
modeloPhone.ReceberLigacao();
modeloPhone.Ligar();