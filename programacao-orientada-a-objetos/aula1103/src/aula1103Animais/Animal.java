/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula1103Animais;

/**
 *
 * @author hiq
 */
public class Animal {
    private String nome;
    private int idade;
    private float peso;
    private String corOlho;

    public Animal() {
    }

    public Animal(String nome, int idade, float peso, String corOlho) {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
        this.corOlho = corOlho;
    }

    public String getNome() {
        return nome;
    }

    public int getIdade() {
        return idade;
    }

    public float getPeso() {
        return peso;
    }

    public String getCorOlho() {
        return corOlho;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public void setCorOlho(String corOlho) {
        this.corOlho = corOlho;
    }
    
    public void dormir() {
        System.out.println("animal dormindo..");
    }
    
    public void comer() {
        System.out.println("animal comendo.. nom nom nom");
    }
}
