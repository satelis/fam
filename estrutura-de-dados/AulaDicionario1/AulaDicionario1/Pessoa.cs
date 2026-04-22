using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaDicionario1 {
    internal class Pessoa {
        private string nome;
        private string cidade;
        private double renda;
        private int filhos;
        private bool atividade;
        private char genero;
        private int tempoEmpresa;
        private bool promovido;
        private Dictionary<int, Pessoa> dp;

        public Pessoa(string nome, string cidade, double renda, int filhos, bool atividade, char genero, int tempoEmpresa, bool promovido) {
            this.nome = nome;
            this.cidade = cidade;
            this.renda = renda;
            this.filhos = filhos;
            this.atividade = atividade;
            this.genero = genero;
            this.tempoEmpresa = tempoEmpresa;
            this.promovido = promovido;
        }
        
        public Pessoa(Dictionary<int, Pessoa> p) {
            this.dp = p;
        }

        public void ImprimeChaves(Dictionary<int, Pessoa> pes) {
            foreach (var item in pes.Keys) {
                Console.WriteLine("{0}", item);
            }
        }

        public void ImprimeValores(Dictionary<int, Pessoa> pes) {
            Console.WriteLine("\nImpressão dos valores:");
            foreach (var item in pes.Values) {
                Console.WriteLine("{0, -20} {1, -22} {2, 12:C2} {3, 6} {4, 10} {5, 8} {6, 4} {7, 9}", item.nome, item.cidade, item.renda, item.filhos, item.atividade, item.genero, item.tempoEmpresa, item.promovido);
            }
        }

        public void ImprimeDicionario() {
            Console.WriteLine("\nImprimindo dicionário:");
            foreach (var item in dp) {
                Console.WriteLine("{0, 4} {1, -21} {2, -22} {3, 12:C2} {4, 6} {5, 10} {6, 8} {7, 4} {8, 9}", item.Key, item.Value.nome, item.Value.cidade, item.Value.renda, item.Value.filhos, item.Value.atividade, item.Value.genero, item.Value.tempoEmpresa, item.Value.promovido);

            }
        }
    } 
}
