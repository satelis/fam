package exercicio06.aula05;

/**
 * @author hiq
 */
public abstract class CartaoWeb {
    //variavel destinatario, será herdada para todas as outras classes.
    protected String destinatario;

    //construtor padrão
    public CartaoWeb(String destinatario) {
        this.destinatario = destinatario;
    }

    //getters e setters
    public String getDestinatario() {
        return destinatario;
    }

    public void setDestinatario(String destinatario) {
        this.destinatario = destinatario;
    }

    //definindo que haverá a declaração de um método de mensagem
    public abstract void showMessage();
   
}
