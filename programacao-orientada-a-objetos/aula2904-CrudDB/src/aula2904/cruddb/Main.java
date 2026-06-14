package aula2904.cruddb;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Main {

    public static void main(String[] args) {
        Connection vCon = new Banco().getCon();
        
        try{
            System.out.println("O nome do DB é: " + vCon.getCatalog());
            
            String sql = "SELECT * FROM pessoa";
            Statement statement = vCon.createStatement();
            ResultSet result = statement.executeQuery(sql);
            
            while (result.next()) {
                int id = result.getInt("Código");
                String nome = result.getString("nome");
                String mail = result.getString("email");
                String fone = result.getString("telefone");
                
                System.out.println(id + "," + nome + ", " + mail + ", " + fone);
            }
            
        } catch (SQLException ex) {
            System.getLogger(Main.class.getName()).log(System.Logger.Level.ERROR, (String) null, ex);
        }
    }
    
}
