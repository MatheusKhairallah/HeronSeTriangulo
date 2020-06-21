using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números decimais maiores que zero");
            Console.Write("Primeiro número: ");
            double A=Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo número: ");
            double B=Convert.ToDouble(Console.ReadLine());
            Console.Write("Terceiro número: ");
            double C=Convert.ToDouble(Console.ReadLine());

            double resultado_S=(A + B + C) / 2;
            
            double resultado_A=resultado_S - A;
            double resultado2_A=resultado_S - B;
            double resultado3_A=resultado_S - C;
            double resultado4_A=resultado_S * resultado_A * resultado2_A * resultado3_A;
            double resultado5_A=Math.Sqrt(resultado4_A);

            Console.Clear();
            
            if(A<(B+C) && A > Math.Abs(B - C) && B < (A + C) && B > Math.Abs(A - C) && C < (A + B) && C > Math.Abs(A - B))
            Console.WriteLine($"Os números digitados corespondem aos lados de um triângulo");
            else
            Console.WriteLine($"Os números digitados não corespondem aos lados de um triângulo");

            if(A==B && A==C && B==A && B==C && C==A && C==B)
            Console.WriteLine($"Seu triângulo é do tipo Equilátero");
            else if(A!=B && A!=C && B!=A && B!=C && C!=A && C!=B)
            Console.WriteLine($"Seu triângulo é do tipo Escaleno");
            else
            Console.WriteLine($"Seu triângulo é do tipo Isósceles");

            Console.WriteLine($"Área do triângulo pelo Teorema de Heron é= {resultado5_A}");

           




            
            




        }
    }
}
