using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDicionario1 {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<int, Pessoa> dic = new Dictionary<int, Pessoa>() {
                {1, new Pessoa("Zé","Americana", 4321.10, 2, true, 'M', 3, false) },
                {2, new Pessoa("Patasquio Pataqua", "Limeira", 3698.24, 2, false, 'M', 3, false) },
                {3, new Pessoa("Tiburcio Coiote", "São Paulo", 3723.60, 3, true, 'M', 1, true)},
                {4, new Pessoa("Rozalino Ritalino", "São Paulo", 4501.37, 1, true, 'M', 4, true)},
                {5, new Pessoa("Faganeto Rogueti", "Santa Bárbara d´Oeste", 2992.05, 2, true, 'M', 3, true)},
                {6, new Pessoa("Astrogildo Samanco", "Sumaré", 2850.48, 0, true, 'M', 1, true)},
                {7, new Pessoa("Chica da Silva", "Rio Claro", 3481.57, 0, true, 'F', 1, true)},
                {8, new Pessoa("Juvenal Mosquera", "São Paulo", 3028.51, 0, true, 'M', 0, false)},
                {9, new Pessoa("Margarida Viola", "Piracicaba", 3569.92, 2, true, 'F', 3, true)},
                {10, new Pessoa("Dafra Topata", "Piracicaba", 1987.58, 1, false, 'F', 4, true)},
                {11, new Pessoa("Raquelina Albra", "Santa Bárbara d´Oeste", 3718.94, 2, true, 'F', 4, false)},
                {12, new Pessoa("Tormentina Mianto", "Sumaré", 2845.48, 1, true, 'F', 4, true)},
                {13, new Pessoa("Fizema Igarro", "Americana", 3937.45, 2, true, 'F', 2, false)},
                {14, new Pessoa("Bartina Lagame", "Piracicaba", 4074.37, 3, true, 'F', 3, true)},
                {15, new Pessoa("Cremilda Tutibona", "Americana", 4873.04, 1, true, 'F', 2, false)},
                {16, new Pessoa("Pragilda Lunataque", "Limeira", 3985.82, 1, true, 'F', 4, false)},
                {17, new Pessoa("Piangela Alvira", "São Paulo", 4034.95, 4, true, 'F', 4, true)},
                {18, new Pessoa("Gatunilda Amiuna", "Santa Bárbara d´Oeste", 3639.47, 2, true, 'F', 4, false)},
                {19, new Pessoa("Lartina Dumante", "Limeira", 2957.84, 0, true, 'F', 5, true)},
                {20, new Pessoa("Ursula Cavasca", "Americana", 3748.48, 2, true, 'F', 4, false)},
                {21, new Pessoa("Alairton Masquero", "Piracicaba", 3981.42, 2, true, 'M', 5, false)}
            };

            Pessoa p = new Pessoa(dic);
            p.ImprimeChaves(dic);
            p.ImprimeValores(dic);
            p.ImprimeDicionario();

            /* PRIMEIROS EXEMPLOS
            Dictionary<int, string> maquina = CarregaDados();
            ImprimeChaves(maquina);
            ImprimeValores(maquina);
            ImprimeDicionario(maquina);
            */
        }

        static Dictionary<int, string> CarregaDados() {
        Dictionary<int, string> carro = new Dictionary<int, string>() {
            {1, "Marea"},
            {2, "Eclipse"},
            {3, "Caravan"},
            {4, "Opala"}
        };

        return carro;   
        }

        static void ImprimeChaves(Dictionary<int, string> car) {
            Console.WriteLine("1ª forma");
            foreach (var item in car) {
                Console.WriteLine("{0}", item.Key);
            }

            Console.WriteLine("\n2ª forma");
            foreach (var item in car.Keys) {
                Console.WriteLine("{0}", item);
            } 
        }

        static void ImprimeValores(Dictionary<int, string> car) {
            Console.WriteLine("1ª forma");
            foreach (var item in car) {
                Console.WriteLine("{0}", item.Value);
            }

            Console.WriteLine("\n2ª forma");
            foreach (var item in car.Values) {
                Console.WriteLine("{0}", item);
            } 
        }
        static void ImprimeDicionario(Dictionary<int, string> car) {
            Console.WriteLine("\nImprimindo o dicionário");
            foreach (var item in car) {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }

    }
}
