namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa 
    {
        public Aluno(string nome, string sobrenome, string nota) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe Aluno");
        }
    }
}