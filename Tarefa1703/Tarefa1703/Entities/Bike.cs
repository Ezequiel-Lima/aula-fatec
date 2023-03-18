namespace Tarefa1703.Entities
{
    public class Bike : Veiculo
    {
        public Bike(int numeroPortas, int numeroAssentos, bool temMotor, int velocidadeMaxima) : base(numeroPortas, numeroAssentos, temMotor)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        public int VelocidadeMaxima { get; private set; }
    }
}
