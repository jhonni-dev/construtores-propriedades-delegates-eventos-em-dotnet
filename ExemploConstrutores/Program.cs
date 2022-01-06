using ExemploConstrutores.Models;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno ("Jhonni", "Lima", "Matemática");
        aluno.Apresentar();
        // Log log = Log.GetInstance();
        // log.PropriedadeLog = "Teste instância";
        // Log log2 = Log.GetInstance();
        // System.Console.WriteLine(log2.PropriedadeLog);

        // Pessoa p1 = new Pessoa();
        // p1.Apresentar();
    }
}