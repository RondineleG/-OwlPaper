
package formacaojava;

public class Variaveis 
{
    public static void main(String [] args)
    {
        // imprime a idade
        int idade = 20;
        System.out.println(idade);

        // gera uma idade no ano seguinte
        int idadeNoAnoQueVem;
        idadeNoAnoQueVem = idade + 1;

        // imprime a idade
        System.out.println(idadeNoAnoQueVem);

       int quatro = 2 + 2; //Adicao
       int tres = 5 - 2; //Subtracao
       int oito = 4 * 2; //Multiplicacao
       int dezesseis = 64 / 4; // Divisao
       int um = 5 % 2; // 5 dividido por 2 dá 2 e tem resto 1, o operador % pega o resto da divisão inteira
       
       System.out.println(quatro + tres + oito + dezesseis + um);


       System.out.println(idadeNoAnoQueVem);

       if (idade < 18) 
       {
        System.out.println("Não pode entrar");

        /*
         comentário daqui,
        ate aqui
         */

       // uma linha de comentário sobre a idade

       double pi  = 3.14;
       double x = 5 * 10;
       boolean verdade = true;
       idade = 30;
       
       if(verdade == false)
       {
         System.out.println(idadeNoAnoQueVem);
         pi = x;
       }
        int novoPI = (int) pi;
       boolean menorDeIdade = (idade < 18) && (idade < novoPI);
       System.out.println(menorDeIdade);
       char letra = 'A';
       System.out.println(letra);

       int i = 5; // i recebe uma cópia do valor 5
       int j = i; // j recebe uma cópia do valor de i
       i = i + 1; // i vira 6, j continua 5
       System.out.println(i + j);
       //casting

      double d3 = 3.14;
       int ia = (int) d3;
       System.out.println(ia);
       long xl = 10000;
       System.out.println(xl);
       // int il = xl;  não compila, pois pode estar perdendo informação





}      }    

}

