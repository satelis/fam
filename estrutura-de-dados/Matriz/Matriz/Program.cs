using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Horários dos laboratórios");
            string[,] mat = CarregaMatriz();

            ImprimeMatriz(mat);

            Console.WriteLine("\nHorários do professor: ");
            ImprimeMatriz(MontaHorarioProfessor(mat));
        }


        static string[,] CarregaMatriz() {
            string[,] mat = new string[,] {
                {"Alex-Algoritmos", "Alex-Algoritmos", "Taglietta-Sistemas", "Alex-Lógica", ""},
                {"Marcio Veleda-Interface", "Lucas Serafim-Analise Proj.", "Alex-Interface Homem", "Sidinei-Analise de Proj.", ""},
                {"Hernani-Sistema distribuídos", "Lucas Serafim-Analise Proj.", "Alex-Interface Homem", "Sidinei-Analise de Proj.", ""},
                {"Hernani-sistemas distribuídos", "Lucas Serafim-Analise Proj.", "Alex-Verificação Soft.", "Sidinei-Analise de Proj.", ""},
                {"Sidinei-Arquitetura", "Sidinei-Arquitetura", "Sidinei-Analise Proj", "Paulo Cesar-Estrutura D", ""},
                {"Sidinei-Arquitetura", "Sidinei-Arquitetura", "Sidinei-Analise Proj", "Paulo Cesar-Estrutura D", ""},
                {"Evandro-Banco de dados", "Fabio Ale-Logica", "Evandro-Banco de dados", "Evandro-Banco de dados", "Vinicios-Eng Prod.-Tcc I e II"},
                {"Evandro-Banco de dados", "Fabio Ale-Ling Formais", "Evandro-Banco de dados", "Evandro-Banco de dados", "Sandra-Eng Prod.-Estagio I e II"},
                {"Valmir-Design Digital", "Laisa Lemes-Tópicos Integr", "Valmir-Design Digital", "Eliandro-Compu. Grafica", "Eliandro-Compu. Grafica"},
                {"Valmir-Design Digital", "Laisa Lemes-Tópicos Integr", "Valmir-Design Digital", "Eliandro-Compu. Grafica", "Eliandro-Compu. Grafica"},
                {"Fujita-Arquitetura", "Fujita-Estrutura de dados", "Fujita-Estrutura de dados", "", "Fujita-SO"},
                {"Fujita-Arquitetura", "Fujita-Estrutura de dados", "Fujita-Estrutura de dados", "", "Fujita-SO"},
                {"Marcos Anto-Projeto Digital", "Leonardo H-Projeto Arqui", "Ana Rita-Sistemas distribuídos.", "Nelson-Eng Prod.-Sistema Info.", "Sandra-Computação para Eng"},
                {"Sandra-Eng. Prod.", "Leonardo H-Projeto Arqui", "Ana Rita-Audit Sistemas-15 dias", "Nelson-IA", "Sandra-Computação para Eng"},
                {"Taglietta-Sistemas", "Sebastiao-Comp. nuvem", "Sebastiao-Comp. Nuvem", "Raul Cesar-Algoritmos", ""},
                {"Taglietta-Sistemas", "Sebastiao-Comp. nuvem", "Sebastiao-Comp. Nuvem", "Raul Cesar-Algoritmos", ""},
                {"Lucas Serafim-Tópicos Especiais", "Rosemary-Projeto Digital", "Welton-Desenho", "", "Rosemary-Proj. Digital"},
                {"Lucas Serafim-Tópicos Especiais", "Rosemary-Projeto Digital", "Welton-Desenho", "", ""}
            };

            return mat;
        }

        static void ImprimeMatriz(string[,] hor) {
             for (int i = 0; i < hor.GetLength(0); i++) {
                for (int j = 0; j < hor.GetLength(1); j++) {
                    Console.Write("{0, -33}", hor[i, j]);
                }
                Console.WriteLine();
            }
        }

        static string[,] MontaHorarioProfessor(string[,] mat) {
            string[,] prof = new string[2, 5];

            int priUlt = 0;

            for (int i = 0; i < mat.GetLength(0); i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {

                    if (mat[i, j].Contains("Raul")) {
                        /*
                         if (i % 2 == 0) {
                            priUlt = 0;
                        }
                        else {
                            priUlt = 1;
                        }
                         
                         OU*/
                        priUlt = i % 2 == 0 ? 0 : 1;
                        prof[priUlt, j] = mat[i, j];
                    }
                }
            }
            return prof;
        }
    }
}
