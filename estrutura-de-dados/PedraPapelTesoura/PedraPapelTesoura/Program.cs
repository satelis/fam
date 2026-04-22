using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura {
    internal class Program {
        static void Main(string[] args) {
            string[,] regras = {
                {"Empate", "Papel", "Pedra" },
                {"Papel", "Empate", "Tesoura" },
                {"Pedra", "Tesoura", "Empate" }
            };

            Console.WriteLine("player 1:");
            string jogadaP1 = FazerJogada();

            Console.WriteLine("player 2:");
            string jogadaP2 = FazerJogada();

            Console.WriteLine(RealizarJogo(regras, jogadaP1, jogadaP2));
        }

        static string FazerJogada() {
            Console.WriteLine("Escolha sua jogada!");
            return Console.ReadLine().ToUpper().Trim();
        }

        static string RealizarJogo(string[,] jogo, string jogadaPlayer1, string jogadaPlayer2) {
            int linha = -1, coluna = -1;

            switch (jogadaPlayer1) {
                case "PEDRA": linha = 0; break;
                case "PAPEL": linha = 1; break;
                case "TESOURA": linha = 2; break;
            }

            switch (jogadaPlayer2) {
                case "PEDRA": coluna = 0; break;
                case "PAPEL": coluna = 1; break;
                case "TESOURA": coluna = 2; break;
            }

            return jogo[linha, coluna];
        }
    }
}
