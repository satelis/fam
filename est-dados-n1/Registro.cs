using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace est_dados_n1 {
    internal class Registro {
        //dados para o registro
        private string nomeProprietario;
        private double valorVeiculo;
        private string estado;
        private int anoFabricacao;
        
        //variaveis regioes
        private string regiao;
        private Dictionary<string, string> regioes = new Dictionary<string, string>() {
            {"SC","Sul"},
            {"PR","Sul"},
            {"RS","Sul"},
            {"SP","Sudeste"},
            {"RJ","Sudeste"},
            {"ES","Sudeste"},
            {"MG","Sudeste"},
            {"DF","Centro-Oeste"},
            {"GO","Centro-Oeste"},
            {"MS","Centro-Oeste"},
            {"MT","Centro-Oeste"},
            {"RN","Norte"},
            {"RR","Norte"},
            {"RO","Norte"},
            {"AM","Norte"},
            {"AC","Norte"},
            {"TO","Norte"},
            {"PA","Norte"},
            {"AP","Norte"},
            {"PE","Nordeste"},
            {"BA","Nordeste"},
            {"CE","Nordeste"},
            {"PI","Nordeste"},
            {"MA","Nordeste"},
            {"SE","Nordeste"},
            {"AL","Nordeste"},
            {"PB","Nordeste"}
        };
        
        private Dictionary<string, double> impostoPorRegiao = new Dictionary<string, double>() {
            {"Sul", 3.5},
            {"Sudeste", 4.5},
            {"Centro-Oeste", 5.2},
            {"Norte", 4.8},
            {"Nordeste", 4.9}
        };

        //construtor
        public Registro(string nomeProprietario, double valorVeiculo, string estado, int anoFabricacao) {
            this.nomeProprietario = nomeProprietario;
            this.valorVeiculo = valorVeiculo;
            this.estado = estado.ToUpper();
            this.anoFabricacao = anoFabricacao;
            regiao = regioes[estado];
        }

        //passa a lista criada no main para a classe registro
        private List<Registro> lista;
        public void CarregaLista(List<Registro> listaMain) {
            lista = listaMain;
        }


        //1- imprimir por regiao
        public void ImprimePorRegiao(string regiaoEscolhida) {
            
        }
    }
}
