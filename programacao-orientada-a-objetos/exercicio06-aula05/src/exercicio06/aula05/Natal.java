package exercicio06.aula05;

/**
 * @author hiq
 */
public class Natal extends CartaoWeb {

    //construtor do cartão natal
    public Natal(String destinatario) {
        super(destinatario);
    }
    
    //declaração (da classe Natal) do método abstrato da classe CartaoWeb
    @Override
    public void showMessage() {
        System.out.println("Feliz Natal, " + destinatario + "! Meu verdadeiro presente é você.");
    }
    
}
