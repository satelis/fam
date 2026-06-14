/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula1803;

/**
 *
 * @author hiq
 */
public class Circulo extends Ponto {
    protected double radius;
    
    public Circulo(double vX, double vY, double vRadius) {
        super(vX, vY);
        radius = vRadius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }
    
    
}
