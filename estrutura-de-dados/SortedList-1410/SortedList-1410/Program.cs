using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_1410 {
    internal class Program {
        static void Main(string[] args) {
            /* usando sortedlist com <string, int>
            SortedList<string, int> membros = CarregaDados();
            ImprimeLista(ref membros);
            */

            SortedList<DateTime, int> calend = CarregaDados();
            ImprimeDatas(ref calend);
            ImprimeSomenteDatas(ref calend);

        }
        // usando DateTime 
        static SortedList<DateTime, int> CarregaDados() {
            return new SortedList<DateTime,int>() {
                {new DateTime(2025, 10, 14), 3},
                {new DateTime(2024, 9, 15), 8 },
                {new DateTime(2001, 6, 13), 5 },
                {new DateTime(2010 , 1, 10), 2 },
                {new DateTime(2012 , 4, 17), 4 },
                {new DateTime(2018, 12, 22), 2 },
                {new DateTime(2016, 5, 1), 6 },
                {new DateTime(2015, 2, 20), 7 }
            };
        }

        static void ImprimeDatas(ref SortedList<DateTime, int> datas) {
            Console.WriteLine("Imprimindo lista:");
            foreach (var item in datas) {
                //toShortDateString evita que as horas sejam impressas também.
                Console.WriteLine("{0} {1}", item.Key.ToShortDateString(), item.Value);
            } 

        }

        static void ImprimeSomenteDatas(ref SortedList<DateTime, int> datas) {
            Console.WriteLine("\nImprimindo somente datas:");
            foreach (var item in datas) {
                Console.WriteLine("{0}", item.Key.ToShortDateString());
            }

        
        }
        


        /* USANDO SORTEDLIST COM <STRING, INT>
        static SortedList<string, int> CarregaDados() {
            SortedList<string, int> familia = new SortedList<string, int>() {
                {"João", 1992},
                {"Maria", 1998 },
                {"Zezinho", 2010 },
                {"Pedro", 2002 },
                {"Fernanda", 2005 }
            };

            return familia;
        }

        static void ImprimeLista(ref SortedList<string, int> familia) {
            foreach (var item in familia) {
                Console.WriteLine("{0, -10} {1,5}", item.Key, item.Value);
            }
        }
        */
    }
}
