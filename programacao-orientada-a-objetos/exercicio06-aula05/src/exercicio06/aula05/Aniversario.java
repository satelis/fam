package exercicio06.aula05;

/**
 * @author hiq
 */
public class Aniversario extends CartaoWeb {
    //construtor classe aniversario
    public Aniversario(String destinatario) {
        super(destinatario);
    }

    //declaração (da classe Natal) do método abstrato da classe CartaoWeb
    @Override
    public void showMessage() {
        System.out.println("Te adoro! Feliz Aniversário, " + destinatario + "!");
    }   
}
