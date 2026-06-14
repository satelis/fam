/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula1803.pkg02;

/**
 *
 * @author hiq
 */
public class Aluno extends Pessoa {
    protected int ra;

    public Aluno() {
    }

    public Aluno(int ra, String nome, String fone) {
        super(nome, fone);
        this.ra = ra;
    }

    public int getRa() {
        return ra;
    }

    public void setRa(int ra) {
        this.ra = ra;
    }
    
    @Override
    public void mostraDados() {
        System.out.println("Dados do aluno\nNome: " + getNome() + "\nTelefone: " + getFone() + "\nRA: " + getRa());
    }
    
    
    
}
