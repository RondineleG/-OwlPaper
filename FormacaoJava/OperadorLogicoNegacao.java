
package formacaojava;

public class OperadorLogicoNegacao {
    public static void main(String [] args)
    {
        int idade = 15;
        boolean amigoDoDono = true;
        if (idade < 18 && !amigoDoDono) {
            System.out.println("Não pode entrar");
        }
        else {
            System.out.println("Pode entrar");
        }

        int mes = 1;
        if (mes == 1) {
       System.out.println("Você deveria estar de férias");
       }
    
    }    
}
