/**
 * @author hiq
 */
public class NotificacaoEmail implements Notificacao {

    public NotificacaoEmail() {
    }
    
    @Override
    public void enviar(String mensagem) {
        System.out.println("Enviando E-mail: " + mensagem);
    }
    
    
}
