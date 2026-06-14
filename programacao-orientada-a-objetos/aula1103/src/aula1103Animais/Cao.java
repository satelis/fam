/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula1103Animais;

/**
 *
 * @author hiq
 */
public class Cao extends Mamifero {
    
    public Cao() {
        
    }

    public Cao(String corPelo, float comprimentoPelo, String nome, int idade, float peso, String corOlho) {
        super(corPelo, comprimentoPelo, nome, idade, peso, corOlho);
    }
    
    public void latir() {
        System.out.println("Cao latindo.. Au au au");
    }
    
}
