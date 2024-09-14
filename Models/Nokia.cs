namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        //Construtor X
        
        public Nokia(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        
    // TODO: Sobrescrever o método "InstalarAplicativo" X
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando Novo APP {nomeApp} em"+
                    $"\nNoKia : {Modelo}\nMemoria Total {Memoria}GB");
        }
    }
}