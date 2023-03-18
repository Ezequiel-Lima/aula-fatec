namespace Tarefa1703.Entities
{
    public class Carro : Veiculo
    {
        public Carro(int numeroPortas, int numeroAssentos, bool temMotor, bool cintoSeguranca, bool arCondicionado, string marcaRadio, string fabricante) 
            : base(numeroPortas, numeroAssentos, temMotor)
        {
            CintoSeguranca = cintoSeguranca;
            ArCondicionado = arCondicionado;
            MarcaRadio = marcaRadio;
            Fabricante = fabricante;
        }

        public bool CintoSeguranca { get; private set; }
        public bool ArCondicionado { get; private set; }
        public string MarcaRadio { get; private set; }
        public string Fabricante { get; private set; }
    }
}
