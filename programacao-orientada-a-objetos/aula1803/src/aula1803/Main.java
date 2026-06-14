/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aula1803;

/**
 *
 * @author hiq
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Ponto p = new Ponto(10,15);
        System.out.println("As coordenadas X e Y são: " + p.getX() + " "+ p.getY());
        
        Circulo c1 = new Circulo(10, 15, 5);
        System.out.println("As coordenadas do circulo são: " + c1.getX() + " " + c1.getY() + " " + c1.getRadius());
    }
}
