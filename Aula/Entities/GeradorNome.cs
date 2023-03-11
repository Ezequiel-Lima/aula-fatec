namespace Aula.Entities
{
    public static class GeradorNome
    {
        private readonly static string[] primeiroNome = { "Ezequiel", "Ketlen", "Marcos", "Livia", "Hugo", "Matheus", "Leticia" };
        private readonly static string[] segundoNome = { "Santos", "Lima", "Luna", "Gregorio", "Paganin", "Vedroni", "Chaves" };
        private static readonly Random random = new Random();

        public static string Gerar()
        {
            string nome = primeiroNome[random.Next(primeiroNome.Length)];
            string sobrenome = segundoNome[random.Next(segundoNome.Length)];

            return $"{nome} {sobrenome}";
        }
    }
}
