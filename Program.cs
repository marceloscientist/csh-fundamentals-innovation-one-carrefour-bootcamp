using System;


namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Student[] students = new Student[5];
            int studentIndex = 0;

            do
            {
                opcao = getUserOption();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do aluno: ");
                        Student student = new Student();
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Digite sua nota: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal score))
                        {
                            student.Score = score;
                        }
                        else
                        {
                            throw new ArgumentException("It must be a decimal score. eg: 10.0");
                        }
                        students[studentIndex] = student;
                        studentIndex++;

                        doubleBreakLines();
                        break;

                    case "2":
                        Console.WriteLine("Alunos desta sala são: ");
                        foreach (Student el in students)
                        {
                            if (!string.IsNullOrEmpty(el.Name))
                                Console.Write($"{el.Name} has got {el.Score} at this test");
                        }
                        doubleBreakLines();
                        break;

                    case "3":
                        decimal totalScore = 0;
                        int totalStudents = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].Name))
                            {
                                totalScore += students[i].Score;
                                totalStudents++;
                            }
                        }
                        decimal averageScore = totalScore / totalStudents;

                        EConcept globalConcept;
                        if (averageScore < 2)
                        {
                            globalConcept = EConcept.E;
                        }
                        else if (averageScore < 4)
                        {
                            globalConcept = EConcept.D;
                        }
                        else if (averageScore < 6)
                        {
                            globalConcept = EConcept.C;
                        }
                        else if (averageScore < 8)
                        {
                            globalConcept = EConcept.B;
                        }
                        else {
                            globalConcept = EConcept.A;
                        }

                        
                        Console.WriteLine($"Média geral da turma foi de {averageScore} | The global concept is {globalConcept} ");
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
