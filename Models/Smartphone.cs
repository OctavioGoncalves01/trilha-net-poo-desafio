namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        //Construtor X
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
        // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        //Numero Publico
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        //Modelo Protegido X
        protected string Modelo {get; set;}

        //Imei Protegido X
        protected string Imei {get; set;}

        //Memoria protegida X
        protected int Memoria {get; set;}



    //Parametros

        //Metodo ligar publico
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }


        //Metodo receber ligações Publico
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

    //Metodo abstrato Instalar app
        public abstract void InstalarAplicativo(string nomeApp);
    }
}