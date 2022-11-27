namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine(String.Format("{0} Instalado, no {1}", nomeApp,this.Modelo));
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("Erro:{0}", e));
            }
        }
    }
}