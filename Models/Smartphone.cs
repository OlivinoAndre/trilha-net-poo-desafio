namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get { return _Modelo;} }
        public string IMEI { get { return _IMEI;} }
        public int Memoria { get { return _Memoria;} }
        protected string _Modelo;
        protected string _IMEI;
        protected int _Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _Modelo = modelo;
            _IMEI = imei;
            _Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}