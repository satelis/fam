/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula0403;

/**
 *
 * @author hiq
 */
public class Pessoa {
    private String nome;
    private int idade;
    
    public Pessoa(String nome, int idade) {
        if (!nome.isEmpty()) {
            this.nome = nome;
        }
        if (idade > 0) {
            this.idade = idade;            
        }
    }
    
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        if (nome != null)
            this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        if (idade > 0)
            this.idade = idade;
    }
    
    public String getFaixaEtaria() {
        if (idade < 12 ) {
            return "Criança";
        
        } else
            if (idade < 18) {
                return "Adolescente";
            }
        else
               return "Adulto";
    }
    
    
}
