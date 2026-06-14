/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aula0403;

import java.util.Scanner;

public class Aula0403 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        /* EXEMPLO 1
        Pessoa p = new Pessoa();
        p.setNome("Pedro");
        p.setIdade(2);
        System.out.println("Seu nome é: " + p.getNome() + "e você tem " + p.getIdade() + " anos."); */
   
        /* EXEMPLO 2
        Scanner leitor = new Scanner(System.in);
        
        Pessoa p = new Pessoa();
        System.out.println("Digite seu nome: ");
        p.setNome(leitor.next());
        
        System.out.println("Digite sua idade: ");
        p.setIdade(leitor.nextInt());
        
        System.out.println("Seu nome é: " + p.getNome() + " e você tem " + p.getIdade() + " anos.");*/
        
        Pessoa p = new Pessoa("Júlia", 20);
        System.out.println("Seu nome é: " + p.getNome() + " e você tem: "+ p.getIdade() + " anos.");
        
    }
    
}
