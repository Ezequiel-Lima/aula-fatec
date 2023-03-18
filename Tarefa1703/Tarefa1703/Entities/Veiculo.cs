namespace Tarefa1703.Entities
{
    public class Veiculo
    {
        public Veiculo(int numeroPortas, int numeroAssentos, bool temMotor)
        {
            Id = Guid.NewGuid();
            NumeroPortas = numeroPortas;
            NumeroAssentos = numeroAssentos;
            TemMotor = temMotor;
        }

        public Guid Id { get; private set; }
        public int NumeroPortas { get; private set; }
        public int NumeroAssentos { get; private set; }
        public bool TemMotor { get; private set; }
    }
}
