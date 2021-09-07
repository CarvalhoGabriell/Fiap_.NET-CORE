namespace FintechRevisao.Models
{
    public class Cliente
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public Cliente(long id, string nome)
        {

        }

        public override string ToString()
        {
            return $" ID: {Id}, Nome: {Nome}, CPF: {Cpf}";
        }
    }
}