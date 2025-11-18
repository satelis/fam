using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace est_dados_n1 {
    internal class Menu {
        bool invalido = false;
        int escolha;
        //deixando a variavel de acesso fora do construtor
        Registro menuAcoes;


        List<Registro> registroList = new List<Registro>() {
            new Registro("Juca Tabulante", 67835, "AM", 2013),
            new Registro("Anna Dias Alves Botafogo", 37989, "AM", 2006),
            new Registro("Ariadne Vieira Nogueira", 42670, "TO", 2013),
            new Registro("Diogo Álvaro Moncorvo", 15840, "RR", 2012),
            new Registro("Mayra Corrêa Aygadoux", 14720, "RO", 2014),
            new Registro("Marcio Da Costa Batista", 61003, "AC", 2009),
            new Registro("Agenor Apolinário Dos Santos Neto", 46005, "PA", 2008),
            new Registro("Juvenal Mosquera", 18938, "AC", 2019),
            new Registro("Bartina Lagame", 63083, "RO", 2016),
            new Registro("Cremilda Tutibona", 16847, "PA", 2007),
            new Registro("Alairton Masquero", 19584, "TO", 2006),
            new Registro("Matusalém Giodize", 89675, "MA", 2018),
            new Registro("Sara Casagrande Barichelo", 48280, "CE", 2019),
            new Registro("Marcos Barbosa Castro Neves", 100230, "MA", 2017),
            new Registro("Stenico Santana Garcia", 57020, "PE", 2010),
            new Registro("Vitor Santos Cunha", 22850, "AL", 2000),
            new Registro("Filipe Cavaleiro De Macedo", 59820, "RN", 2018),
            new Registro("Faganeto Rogueti", 22794, "RN", 2020),
            new Registro("Margarida Viola", 43671, "MA", 2003),
            new Registro("Dafra Topata", 36702, "BA", 2009),
            new Registro("Tormentina Mianto", 25478, "PE", 2012),
            new Registro("Fizema Igarro", 15864, "PI", 2025),
            new Registro("Gatunilda Amiuna", 31035, "SE", 2010),
            new Registro("Lartina Dumante", 28358, "AL", 2022),
            new Registro("Miguelito Fintara", 45812, "MS", 2001),
            new Registro("Raquel Gusmão Pacheco", 37500, "MT", 2011),
            new Registro("Nelson Pascoal Aguiar", 28478, "MS", 2014),
            new Registro("Clériton Sávio Santos", 37623, "DF", 2017),
            new Registro("Rozalino Ritalino", 35910, "GO", 2007),
            new Registro("Chica da Silva", 20578, "DF", 2014),
            new Registro("Piangela Alvira", 24795, "MT", 2008),
            new Registro("Ademar Terentino", 30345, "SP", 2020),
            new Registro("Felizberto Dalemar", 8450, "RJ", 2005),
            new Registro("Julieta Costa Rocha", 40204, "SP", 2004),
            new Registro("Melissa Alessandra Barros", 12810, "RJ", 2009),
            new Registro("Isabela Correia Tavares", 34692, "MG", 2005),
            new Registro("Eleni Magalhães Peres", 40561, "RJ", 2002),
            new Registro("Beatrice Araujo Oliveira", 72601, "SP", 2019),
            new Registro("Daniel Garcia Felicione Napoleão", 73410, "RJ", 2019),
            new Registro("Tiburcio Coiote", 57096, "ES", 2003),
            new Registro("Pragilda Lunataque", 11829, "MG", 2002),
            new Registro("Ursula Cavasca", 35204, "ES", 2012),
            new Registro("Tebaldo Vilcar", 112340, "PR", 2024),
            new Registro("Reginaldo Antenor Terranobre", 78240, "RS", 2007),
            new Registro("Rodrigo de Paula Benito", 73980, "PR", 2022),
            new Registro("Leticia Ramos Queiroz", 15709, "SC", 2013),
            new Registro("Luan Barros Cardoso", 9450, "RS", 2000),
            new Registro("Patasquio Pataqua", 14326, "SC", 2011),
            new Registro("Astrogildo Samanco Castrol", 51246, "RS", 2023),
            new Registro("Raquelina Albra", 45602, "PR", 2021)
        };

        Dictionary<string, string> opcoes = new Dictionary<string, string>() {
            {"1", "Norte"},
            {"2", "Nordeste"},
            {"3", "Centro-Oeste"},
            {"4", "Sudeste"},
            {"5", "Sul"}
        };

        public Menu() {
            menuAcoes = new Registro(registroList);
            StartaMenu();
        }

        //inicia e loopa menu
        public void StartaMenu() {
            Console.WriteLine("Bem vindo!");
            do {
                Console.WriteLine("\n--- MENU PRINCIPAL ---");
                Console.WriteLine("\nPor favor, selecione uma opção:");
                Console.WriteLine("1- Imprimir lista por Região.");
                Console.WriteLine("2- Imprimir tabela com impostos.");
                Console.WriteLine("3- Imprimir lista por ano de fabricação.");
                Console.WriteLine("4- Gerar relatório de frequência dos anos de fabricação.");
                Console.WriteLine("0- Sair.");
                Console.Write("\nSua opção: ");

                string input = Console.ReadLine();
                //converte o readline(string) pra int
                if (!Int32.TryParse(input, out escolha)) {
                    Console.Clear();
                    Console.WriteLine("Escolha inválida! Digite o número de 0 a 4.");
                    continue;
                }

                switch (escolha) {
                    case 1:
                        Console.Clear();
                        primeiraOpcao();
                        break;

                    case 2:
                        Console.Clear();
                        menuAcoes.ImprimeTabelaImposto();
                        break;

                    case 3:
                        Console.Clear();
                        terceiraOpcao();
                        break;

                    case 4:
                        Console.Clear();
                        menuAcoes.ImprimeFrequenciaAnos();
                        break;

                    case 0:
                        Console.WriteLine("\nObrigado por usar! Saindo...");
                        invalido = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inexistente. Tente novamente.");
                        break;
                }
            } while (!invalido);
        }

        private void primeiraOpcao() {
            string escolhaRegiao;

            do {
                Console.WriteLine("\n--- ESCOLHA DE REGIÃO ---");
                Console.WriteLine("Selecione a região para visualização:");

                foreach (var op in opcoes) {
                    Console.WriteLine($"{op.Key}- {op.Value}");
                }
                Console.WriteLine("0- Voltar ao Menu Principal");
                Console.Write("\nSua opção: ");

                escolhaRegiao = Console.ReadLine();

                if (escolhaRegiao == "0") {
                    Console.Clear();
                    return;
                }

                if (opcoes.ContainsKey(escolhaRegiao)) {
                    string regiaoSelecionada = opcoes[escolhaRegiao];
                    Console.Clear();

                    menuAcoes.ImprimePorRegiao(regiaoSelecionada);

                    Console.WriteLine("\n--- Pressione ENTER para continuar no submenu de Região... ---");
                    Console.ReadLine();
                    Console.Clear();

                }
                else {
                    Console.Clear();
                    Console.WriteLine("Opção de região inválida. Tente novamente.");
                }

            } while (true);
        }

        private void terceiraOpcao() {
            int ano;
            Console.WriteLine("\n--- IMPRIMIR POR ANO DE FABRICAÇÃO ---");
            Console.Write("Digite o ano de fabricação para buscar: ");

            if (Int32.TryParse(Console.ReadLine(), out ano)) {
                Console.Clear();
                menuAcoes.ImprimePorAno(ano);
            }
            else {
                Console.Clear();
                Console.WriteLine("Ano inválido! Por favor, digite um número inteiro.");
            }
        }
    }
}