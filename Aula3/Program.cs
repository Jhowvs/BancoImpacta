using System.Security.Cryptography;

namespace Aula3
{
    // Modificador de acesso internal - O acesso é limitado ao Assembly atual
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a1Nome = "Jhony";
            //string a1Turma = "C#";
            //int a1Idade  = "23";

            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            a1.Nome = "Jhony";
            a1.Turma = "C#";
            a1.idade = 23;
            a1.NMat = 1003;
            a1.Mensalidade = 1000;

            a2.Nome = "Fulano";
            a2.Turma = "C#";
            a2.idade = 26;
            a2.NMat = 1004;

            //Console.WriteLine(new String('-', 50));
            //Console.WriteLine($"Aluno: {a1.Nome} - Turma: {a1.Turma} - Idade: {a1.idade} ");
            //Console.WriteLine(new String('-', 50));
            //Console.WriteLine($"Aluno: {a2.Nome} - Turma: {a2.Turma} - Idade: {a2.idade} ");

            Console.WriteLine( new String ('-', 50));
            a1.ExibirAluno();
            a1.TrocarTurma("ASP.net Core");
            a1.ExibirAluno();
            a1.Desconto(10);
            a1.ExibirAluno();
            //a1.Mensalidade = 500;
        }
    }
}