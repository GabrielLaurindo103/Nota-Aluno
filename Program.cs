using System;

class Program
{
    public static void Main(string[] args)
    {
        double[,] matriz = new double[5, 5];

        for (int aluno = 0; aluno < 5; aluno++)
        {
            Console.WriteLine("**** A L U N O: {0} ****", aluno + 1);
            for (int bimestre = 0; bimestre < 5; bimestre++)
            {
                //Console.WriteLine();
                Console.WriteLine("Digite a nota do {0}º bimestre", bimestre + 1);
                matriz[aluno, bimestre] = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("ALUNO: {0} BIMESTRE: {1} NOTA: {2}", aluno + 1, bimestre + 1, matriz[aluno, bimestre]);
            }
            Console.WriteLine("-------------------------");
        }
    }
}