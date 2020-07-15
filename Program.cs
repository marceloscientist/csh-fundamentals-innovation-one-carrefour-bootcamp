using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                opcao = getUserOption();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("1- Insir novo aluno: ");
                        doubleBreakLines();
                        break;

                    case "2":
                        Console.WriteLine("2- Listar alunos: ");
                        doubleBreakLines();
                        break;

                    case "3":
                        Console.WriteLine("3- Calcular média geral: ");
                        doubleBreakLines();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

            } while (opcao.ToUpper() != "X");

        }

        private static void doubleBreakLines()
        {
            Console.WriteLine();
            Console.WriteLine();
        }

        private static string getUserOption()
        {
            string opcaoAluno;
            Console.WriteLine("Insira a sua opção desejada: ");
            Console.WriteLine("1- Insir novo aluno: ");
            Console.WriteLine("2- Listar alunos: ");
            Console.WriteLine("3- Calcular média geral: ");
            Console.WriteLine("X- Para Sair");
            Console.WriteLine();

            opcaoAluno = Console.ReadLine();
            return opcaoAluno;
        }
    }
}
