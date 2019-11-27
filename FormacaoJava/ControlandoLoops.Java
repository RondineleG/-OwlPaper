
package formacaojava;

public class ControlandoLoops {
    public static void main(String [] args)
    {
        // parar o loop 
        for (int i = x; i < y; i++)
         {
            if (i % 19 == 0) {
                System.out.println("Achei um número divisível por 19 entre x e y");
                break;
            }
        }

       // parar o loop 
        for(int i = 0; i< 100; i++)
        {
            if (i > 50 && i < 60){
              continue;
            }
         System.out.println(i);
        }
 

    }    
}
