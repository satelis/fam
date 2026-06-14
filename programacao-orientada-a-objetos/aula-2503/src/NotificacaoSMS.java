/**
 * @author hiq
 */
public class NotificacaoSMS implements Notificacao {

    public NotificacaoSMS() {
    }

    @Override
    public void enviar(String mensagem) {
        System.out.println("Enviando SMS: " + mensagem);
    }
    
}
