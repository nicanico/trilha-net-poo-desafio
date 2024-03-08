namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        // implementação de construtor base para iphone onde as informações são repassadas para Smartphone - 
        // observar o uso da base
        public Iphone(string numero, string imei, string modelo, string memoria) : base(numero, imei, modelo, memoria){

        }
        

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // observar o uso do override
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}");
        }
    }
}