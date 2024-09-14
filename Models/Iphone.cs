namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" X
    public class Iphone : Smartphone
    {
        //Construtor X
        public Iphone(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {}


        // TODO: Sobrescrever o método "InstalarAplicativo" X
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Aplicativo em IPHONE {Modelo}\nNome APP - {nomeApp}");
        }
    }
}