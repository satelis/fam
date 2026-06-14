    /*
     * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
     * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
     */
    package aula1103Animais;

    /**
     *
     * @author hiq
     */
    public class Aula1103 {

        /**
         * @param args the command line arguments
         */
        public static void main(String[] args) {
            Animal an = new Animal("Lili", 14, 6, "marrom");

            an.dormir();

            Mamifero mf = new Mamifero();

            mf.comer();
            mf.amamentar();

            Cao cc = new Cao();

            cc.latir();
        }

    }
