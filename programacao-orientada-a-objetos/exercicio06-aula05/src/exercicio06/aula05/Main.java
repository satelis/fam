package exercicio06.aula05;

/**
 * @author hiq
 */
public class Main {
    public static void main(String[] args) {
        //Garantindo que o programa irá printar em UTF-8
        System.setOut(new java.io.PrintStream(System.out, true, java.nio.charset.StandardCharsets.UTF_8));

        
        //Iniciando instancias de cada classe
        
        //Instancia Dia dos Namorados - Cartão com destinatário Júlia
        DiaDosNamorados cartaoNamorados = new DiaDosNamorados("Júlia");        
        cartaoNamorados.showMessage();
        
        //Instancia Natal - Cartão com destinatário Heitor
        Natal cartaoNatal = new Natal("Heitor");
        cartaoNatal.showMessage();
        
        //Instancia Aniversário - Cartão com destinatário Maria
        Aniversario cartaoAniversario = new Aniversario("Maria");
        for (int i = 0; i < 100; i++) {
         
        cartaoAniversario.showMessage();
       
        }}
    
}
