using System;
using System.Collections.Generic;

namespace Listas1 {
    internal class Program {
        static void Main(string[] args) {
            //InicializaLista();
            //InicializaLista();
            //AcionaAtravesMetodo();
            //AdicionaListaEmLista();
            //InsereNaPosicao(2, "Julia");
            //RetornaSeContemElemento("melancia");
            //DevolveIndiceTransporte("ônibus");
            //ImprimeUltimaOcorrencia(3);
            RemoveAtravesIndice(2);
        }

        static void InicializaLista() {

            // declarar como "var" também funcionária
            List<string> lista1 = new List<string>() {
                "Toro", "Civic", "Marea", "Uno"
            };

            Console.WriteLine(lista1[1]);

            Console.WriteLine("Todos os carros");

            for (int i = 0; i < lista1.Count; i++) {
                Console.WriteLine(lista1[1]);
            }
        }

        static void InicializaAtravesArray() {
            string[] linguagens = { "C#", "python", "js" };
            List<string> lingprog = new List<string>(linguagens);

            for (int i = 0; i < lingprog.Count; i++) {
                Console.WriteLine(lingprog[i]);
            }
        }
        
        static void AcionaAtravesMetodo() {
            List<int> valores = new List<int> {
                8, -5, 0, 3, -6
            };

            //O método add só aceita um parâmetro por vez.
            valores.Add(1);
            valores.Add(7);

            for (int i = 0; i < valores.Count; i++) {
                Console.WriteLine(valores[i]);
            }
        }

        static void AdicionaListaEmLista() {
            List<int> pares = new List<int>() { 0, 2, 4, 6, 8 };
            List<int> impares = new List<int>() { 1, 3, 5, 7, 9 };
            
            //O método AddRange nos permite adicionar uma lista a outra.
            pares.AddRange(impares);

            //Ordena de forma crescente.
            pares.Sort();

            for (int i = 0; i < pares.Count; i++) {
                Console.Write(pares[i] + " ");
            }

            Console.WriteLine("\nEm ordem decrescente: ");
            pares.Reverse();

            for (int i = 0;i < pares.Count; i++) {
                Console.Write(pares[i] + " /");
            }
        }

        static void InsereNaPosicao(int pos, string nome) {
            List<string> nomes = new List<string>() {
                "Ana", "Carla", "Dani"
            };
            nomes.Insert(pos, nome);

            for (int i = 0; i < nomes.Count; i++) {
                Console.WriteLine(nomes[i]);
            }
        }

        static void RetornaSeContemElemento(string fruta) {
            List<string> quitanda = new List<string>() {
                "amora", "banana", "caqui", "damasco"
            };

            if (quitanda.Contains(fruta.ToLower())) {
                Console.WriteLine("{0} presente na quitanda!", fruta);
            } 
            else {
                Console.WriteLine("Não há {0} na quitanda, porém temos: ", fruta);

                for (int i = 0; i < quitanda.Count; i++) {
                    if (i < quitanda.Count - 2) {
                        Console.Write("{0}, ", quitanda[i]);
                    }
                    else if (i < quitanda.Count - 1) {
                        Console.Write("{0} e ", quitanda[i]);
                    }
                    else {
                        Console.Write("{0}.", quitanda[i]);
                    }
                }
            }
        }

        static void DevolveIndiceTransporte(string t) {
            List<string> trans = new List<string>() {
                "carro", "moto", "ônibus", "van"
            };
            Console.WriteLine(trans.IndexOf(t));
        }

        static void ImprimeUltimaOcorrencia(int num) {
            List<int> inteiros = new List<int>() {
                1,2,3,3,3
            };
            Console.WriteLine("1ª ocorrência de {0}: {1}", num, inteiros.IndexOf(num));
            Console.WriteLine("Última ocorrência de {0}: {1}", num, inteiros.LastIndexOf(num));
        } 
    
        static void RemoveAtravesIndice(int n) {
            List<int> numero = new List<int>() {
                0, 1, 2, 3, 4
            };

            numero.RemoveAt(n);

            for (int i = 0; i < numero.Count; i++) {
                Console.WriteLine(numero[i]);
            }    
        }
    }
}
