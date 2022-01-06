namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        public Pessoa() // construtor vazio
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome) // construtor com parâmetros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá! Meu nome é {nome} {sobrenome}");
        }
    }
}