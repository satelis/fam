/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exercicios0403;

/**
 *
 * @author hiq
 */
public class Exercicios {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Empregado emp = new Empregado("Henrique", "Operacional", 200, 15.2, 10, 20.10);
        
        emp.mostrarDados();
        emp.calculaSalarioMensal();
        emp.calculaSalarioMensalHoraExtra();
    }
    
}
