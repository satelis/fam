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

        //construtor
        public Registro(string nomeProprietario, double valorVeiculo, string estado, int anoFabricacao) {
            this.nomeProprietario = nomeProprietario;
            this.valorVeiculo = valorVeiculo;
            this.estado = estado;
            this.anoFabricacao = anoFabricacao;
        }
    }
}
