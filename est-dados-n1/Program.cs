/* - N1 - Estrutura de Dados -
 * Nomes:
 * Henrique Ferreira Satelis - RA: 20241652
 * Henrique Brancalhão de Oliveira - RA: 20231302
 * Pedro Mazziero - RA: 20240270
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace est_dados_n1 {
    internal class Program {
        static void Main(string[] args) {
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

        Registro reg = new Registro(registroList);

            reg.ImprimePorRegiao("Nordeste");
        }
    }
}

