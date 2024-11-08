namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {       
        public Nokia (string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("instalando Instagram no Nokia");
        }
    }

}