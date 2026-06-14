package aula2904.cruddb;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author hiq
 */
public class Banco {
    public Connection getCon() {
        Connection con = null;
        
        //nomes dos arquivos
        String filename = "C:/Users/hiq/Documents/NetBeansProjects/aula2904-CrudDB/src/aula2904/cruddb/db/Database-aula2904.mdb";
        String database = "jdbc:ucanaccess://" + filename.trim();
        
        try {
            //conecta com o banco de dados
            con = DriverManager.getConnection(database);
        } catch(SQLException e) {
            Logger.getLogger(Banco.class.getName()).log(Level.SEVERE, null, e);
        }
        return con;
    }
}
