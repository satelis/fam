/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package exercicio1103;

/**
 *
 * @author hiq
 */
public class LivroLivraria extends Livro {
    private double preco;

    public LivroLivraria() {
        
    }
    
    public LivroLivraria(double preco, String autor, String editora, int ano, String titulo) {
        super(autor, editora, ano, titulo);
        this.preco = preco;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(float preco) {
        this.preco = preco;
    }
    
    
    
}
