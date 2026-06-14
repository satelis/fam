/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aula1803.pkg03;

import java.io.PrintStream;
import java.nio.charset.StandardCharsets;

/**
 *
 * @author hiq
 */
public class Main {

    public static void main(String[] args) {
        System.setOut(new PrintStream(System.out, true, StandardCharsets.UTF_8));
        
        Forma f1 = new Circulo();
        Forma f2 = new Quadrado();
        
        f1.desenhar();
        f2.desenhar();
        
        Forma[] formas = {new Circulo(), new Quadrado(), new Circulo()};
        for (Forma f : formas) {
            f.desenhar();
        }
    }
    
}
