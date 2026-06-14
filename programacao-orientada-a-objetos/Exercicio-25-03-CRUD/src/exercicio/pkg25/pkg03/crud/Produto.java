package exercicio.pkg25.pkg03.crud;

/**
 * @author hiq
 */
public class Produto {
    private int codigo;
    private String descricao;
    private String grupo;
    private double precoDeCompra;
    private int estoque;
    private double precoDeVenda;
    
    // construtor
    public Produto(int codigo, String descricao, String grupo, double precoDeCompra, double precoDeVenda, int estoque) {
        this.codigo = codigo;
        this.descricao = descricao;
        this.grupo = grupo;
        this.precoDeCompra = precoDeCompra;
        this.precoDeVenda = precoDeVenda;
        this.estoque = estoque;
    }

    //to string para visualização no jframe

    @Override
    public String toString() {
        return ("ID: " + codigo + ", Descrição: " + descricao + ", Grupo: " + grupo + 
                " Preço de Compra: " + precoDeCompra + ", Estoque: " + estoque + ", Preço de Venda: " + precoDeVenda);
    }
    
    
    // getters e setters
    public int getCodigo() {
        return codigo;
    }

    public String getDescricao() {
        return descricao;
    }

    public String getGrupo() {
        return grupo;
    }

    public double getPrecoDeCompra() {
        return precoDeCompra;
    }

    public double getPrecoDeVenda() {
        return precoDeVenda;
    }

    public int getEstoque() {
        return estoque;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }

    public void setPrecoDeCompra(double precoDeCompra) {
        this.precoDeCompra = precoDeCompra;
    }

    public void setEstoque(int estoque) {
        this.estoque = estoque;
    }

    public void setPrecoDeVenda(double precoDeVenda) {
        this.precoDeVenda = precoDeVenda;
    }
    
    
}
