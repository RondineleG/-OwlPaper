
package FormacaoJava;

public class AClassePrincipal {
    public static void main(String [] args)
    { 
        double notaJava = 10;
        
        if( notaJava >6 )
        {
            System.out.println("Java e bom !!!!" );

        }
       
        else if( notaJava >=4 && notaJava <=6 )
        {
            System.out.println("Java e legalzinho !!!!" );

        }
        else if( notaJava >=0 && notaJava <4 )
        {
            System.out.println("Java e muito ruim !!!!" );

        }
   
    }    
}
