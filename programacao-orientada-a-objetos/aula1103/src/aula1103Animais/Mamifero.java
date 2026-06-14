/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula1103Animais;

/**
 *
 * @author hiq
 */
public class Mamifero extends Animal{
    protected String corPelo;
    protected float comprimentoPelo;    

    public Mamifero() {
        
    }

    public String getCorPelo() {
        return corPelo;
    }

    public float getComprimentoPelo() {
        return comprimentoPelo;
    }

    public void setCorPelo(String corPelo) {
        this.corPelo = corPelo;
    }

    public void setComprimentoPelo(float comprimentoPelo) {
        this.comprimentoPelo = comprimentoPelo;
    }

    public Mamifero(String corPelo, float comprimentoPelo, String nome, int idade, float peso, String corOlho) {
        super(nome, idade, peso, corOlho);
        this.corPelo = corPelo;
        this.comprimentoPelo = comprimentoPelo;
    }
    
    public void sentar() {
        System.out.println("Mamifero sentado.");
    }
    
    public void amamentar() {
        System.out.println("Mamifero amamentando");
    }
    
    
    
}   

