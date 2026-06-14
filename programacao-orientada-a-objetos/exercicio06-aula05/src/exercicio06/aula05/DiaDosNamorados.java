
package exercicio06.aula05;

/**
 * @author hiq
 */
public class DiaDosNamorados extends CartaoWeb {    
    //construtor do cartão do dia dos namorados
    public DiaDosNamorados (String destinatario) {
        super(destinatario);
    }       
            
    //declaração (da classe DiaDosNamorados) do método abstrato da classe CartaoWeb
    @Override
    public void showMessage() {
        System.out.println("Feliz dia dos Namorados, " + destinatario + ". Eu te amo sempre!");
    }   
}
