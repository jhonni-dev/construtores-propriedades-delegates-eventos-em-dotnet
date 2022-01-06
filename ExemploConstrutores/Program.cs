using ExemploConstrutores.Models;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Jhonatas", "Lima");
        p1.Apresentar();
    }
}