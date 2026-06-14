/**
 * @author hiq
 */
public class Main {
 
    public static void enviarMensagem(Notificacao servico, String msg) {
        servico.enviar(msg);
    }
    
    public static void main(String[] args) {
        Notificacao servicoEmail = new NotificacaoEmail();
        Notificacao servicoSMS = new NotificacaoSMS();
        
        enviarMensagem(servicoEmail, "Olá via E-mail!");
        enviarMensagem(servicoSMS, "Olá via SMS!");
    }    

}
