using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizDados {
    internal class Program {
        static void Main(string[] args) {
            double[,] rend = CarregaDados();
            string car = EscolheCarro();
            string comb = EscolheCombustivel();
            Console.WriteLine("{0}km/h.",ObtemRendimento(rend, car, comb));
        }
        
        static double[,] CarregaDados() {
            double[,] rendimento = {
                {15, 7.5, 20},
                {14, 7, 19},
                {17, 8.5, 23}
            };
            return rendimento;
        }
        
        static string EscolheCarro() {
            Console.WriteLine("Escolha o carro: ");
            string carro = Console.ReadLine().ToUpper().Trim();

            return carro;
        }

        static string EscolheCombustivel() {
            Console.WriteLine("Combustível: ");
            string combustivel = Console.ReadLine().ToUpper().Trim();
            return combustivel;
        }

        static double ObtemRendimento(double[,] mat, string carro, string combustivel) {
            int linha = -1, coluna = -1;
            
            switch (carro) {
                case "UNO": linha = 0; break;
                case "FOX": linha = 1; break;
                case "GOL": linha = 2; break;
            }

            switch (combustivel) {
                case "GASOLINA": coluna = 0; break;
                case "ETANOL": coluna = 1; break;
                case "GNV": coluna = 2; break;
            }
            return mat[linha, coluna];
        }
    }
}
