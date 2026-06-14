/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package exercicios0403;

/**
 *
 * @author hiq
 */
public class Empregado {
    private String nome;
    private String departamento;
    private int horasTrabalhadas;
    private double salarioHora;
    private int horasExtras;
    private double salarioHoraExtra;
    
    public Empregado(String nome, String departamento, int horasTrabalhadas, 
            double salarioHora, int horasExtras, double salarioHoraExtra) {
        this.nome = nome;
        this.departamento = departamento;
        this.horasTrabalhadas = horasTrabalhadas;
        this.salarioHora = salarioHora;
        this.horasExtras = horasExtras;
        this.salarioHoraExtra = salarioHoraExtra;
    }
    
    public void mostrarDados() {
        System.out.println("Nome: " + nome + ", Departamento: " + departamento + ", Horas trabalhadas: " + 
                horasTrabalhadas + ", Salario por Hora: R$ " + salarioHora + " Horas extras: " + horasExtras + 
                " Salário por Hora Extra: R$ " + salarioHoraExtra);
    }

    public void calculaSalarioMensal() {
        double salario = (double) horasTrabalhadas * salarioHora;
        System.out.printf("\nSalário mensal: R$ %.2f\n", salario);
    }
    
    public void calculaSalarioMensalHoraExtra() {
        double salario = (double) horasTrabalhadas * salarioHora;
        double salarioExtra = (double) horasExtras * salarioHoraExtra;
        double salarioTotal = salario + salarioExtra;
        System.out.printf("\nSalário mensal com horas extras: R$ %.2f\n", salarioTotal);
    }    
}
