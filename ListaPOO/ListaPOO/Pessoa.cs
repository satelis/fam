using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO {
    internal class Pessoa {
        public string nome { get; set; }
        public string cidade { get; set; }
        public double renda { get; set; }
        public int filhos { get; set; }
        public bool atividade { get; set; }
        public char genero { get; set; }
        public int tempoempresa { get; set; }
        public bool promovido { get; set; }
        public List<Pessoa> lista { get; set; }

        public Pessoa(string nome, string cidade, double renda, int filhos, bool atividade, char genero, int tempoempresa, bool promovido) {
            this.nome = nome;
            this.cidade = cidade;
            this.renda = renda;
            this.filhos = filhos;
            this.atividade = atividade;
            this.genero = genero;
            this.tempoempresa = tempoempresa;
            this.promovido = promovido;

        }

        public Pessoa(List<Pessoa> lista) {
            this.lista = lista;
        }

        public void ImrimeListagem() {
            Console.WriteLine("{0,-22} {1,-28} {2, -14} {3, 6} {4, -10} {5, -7} {6, 10} {7, -10}", "Nome", "Cidade", "Renda", "Filhos", "Atividade", "Gênero", "TE", "Promovido");
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine("{0,-22} {1,-28} {2, 8:C2} {3, 9} {4, -10} {5, -7} {6, 10} {7, -10}", lista[i].nome, lista[i].cidade, lista[i].renda, lista[i].filhos, lista[i].atividade, lista[i].genero, lista[i].tempoempresa, lista[i].promovido);

            }
        }

        public void ImprimeListagemAmericana() {
            Console.WriteLine("\nPessoas que moram em Americana:");
            Console.WriteLine("{0,-22} {1,-28} {2, -14} {3, 6} {4, -10} {5, -7} {6, 10} {7, -10}", "Nome", "Cidade", "Renda", "Filhos", "Atividade", "Gênero", "TE", "Promovido");
            for (int i = 0; i < lista.Count; i++) {
                if (lista[i].cidade.ToLower().Equals("americana")) {
                    Console.WriteLine("{0,-22} {1,-28} {2, 8:C2} {3, 9} {4, -10} {5, -7} {6, 10} {7, -10}", lista[i].nome, lista[i].cidade, lista[i].renda, lista[i].filhos, lista[i].atividade, lista[i].genero, lista[i].tempoempresa, lista[i].promovido);

                }
            }
        }
        //pessoas que que ganham mais de 2500 e não moram em americana
        public void ImprimeListagemCriterios() {
            Console.WriteLine("\nPessoas que não moram em Americana e recebem mais de 2500.");
            Console.WriteLine("{0,-22} {1,-28} {2, -14} {3, 6} {4, -10} {5, -7} {6, 10} {7, -10}", "Nome", "Cidade", "Renda", "Filhos", "Atividade", "Gênero", "TE", "Promovido");
            for (int i = 0; i < lista.Count; i++) {
                if (!lista[i].cidade.ToLower().Equals("americana") && lista[i].renda > 2500) {
                    Console.WriteLine("{0,-22} {1,-28} {2, 8:C2} {3, 9} {4, -10} {5, -7} {6, 10} {7, -10}", lista[i].nome, lista[i].cidade, lista[i].renda, lista[i].filhos, lista[i].atividade, lista[i].genero, lista[i].tempoempresa, lista[i].promovido);
                }
            }
        }

        public void DescontaForaAtividade() {
            Console.WriteLine("\nPessoas que tiveram uma redução de 5% por falta de atividade:");
            Console.WriteLine("{0,-22} {1,-28} {2, -14} {3, 6} {4, -10} {5, -7} {6, 10} {7, -10}", "Nome", "Cidade", "Renda", "Filhos", "Atividade", "Gênero", "TE", "Promovido");
            for (int i = 0; i < lista.Count; i++) {
                if (!lista[i].atividade) {
                    Console.WriteLine("{0,-22} {1,-28} {2, 8:C2} {3, 9} {4, -10} {5, -7} {6, 10} {7, -10}", lista[i].nome, lista[i].cidade, lista[i].renda * 0.95, lista[i].filhos, lista[i].atividade, lista[i].genero, lista[i].tempoempresa, lista[i].promovido);
                }
            }
        }

    }
}
