using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO {
    internal class Program {
        static void Main(string[] args) {
            List<Pessoa> pessoas = new List<Pessoa>() {
                new Pessoa("Zé","Americana", 4321.10, 2, true, 'M', 3, false),
                new Pessoa("Patasquio Pataqua", "Limeira", 3698.24, 2, false, 'M', 3, false),
                new Pessoa("Tiburcio Coiote", "São Paulo", 3723.60, 3, true, 'M', 1, true),
                new Pessoa("Rozalino Ritalino", "São Paulo", 4501.37, 1, true, 'M', 4, true),
                new Pessoa("Faganeto Rogueti", "Santa Bárbara d´Oeste", 2992.05, 2, true, 'M', 3, true),
                new Pessoa("Astrogildo Samanco", "Sumaré", 2850.48, 0, true, 'M', 1, true),
                new Pessoa("Chica da Silva", "Rio Claro", 3481.57, 0, true, 'F', 1, true),
                new Pessoa("Juvenal Mosquera", "São Paulo", 3028.51, 0, true, 'M', 0, false),
                new Pessoa("Margarida Viola", "Piracicaba", 3569.92, 2, true, 'F', 3, true),
                new Pessoa("Dafra Topata", "Piracicaba", 1987.58, 1, false, 'F', 4, true),
                new Pessoa("Raquelina Albra", "Santa Bárbara d´Oeste", 3718.94, 2, true, 'F', 4, false),
                new Pessoa("Tormentina Mianto", "Sumaré", 2845.48, 1, true, 'F', 4, true),
                new Pessoa("Fizema Igarro", "Americana", 3937.45, 2, true, 'F', 2, false),
                new Pessoa("Bartina Lagame", "Piracicaba", 4074.37, 3, true, 'F', 3, true),
                new Pessoa("Cremilda Tutibona", "Americana", 4873.04, 1, true, 'F', 2, false),
                new Pessoa("Pragilda Lunataque", "Limeira", 3985.82, 1, true, 'F', 4, false),
                new Pessoa("Piangela Alvira", "São Paulo", 4034.95, 4, true, 'F', 4, true),
                new Pessoa("Gatunilda Amiuna", "Santa Bárbara d´Oeste", 3639.47, 2, true, 'F', 4, false),
                new Pessoa("Lartina Dumante", "Limeira", 2957.84, 0, true, 'F', 5, true),
                new Pessoa("Ursula Cavasca", "Americana", 3748.48, 2, true, 'F', 4, false),
                new Pessoa("Alairton Masquero", "Piracicaba", 3981.42, 2, true, 'M', 5, false)
            };
            
            Pessoa pes = new Pessoa(pessoas);
            pes.ImrimeListagem();
            pes.ImprimeListagemAmericana();
            pes.ImprimeListagemCriterios();
            pes.DescontaForaAtividade();
        }

    }
}
