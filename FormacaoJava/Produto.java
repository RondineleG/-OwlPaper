package formacaojava;

public class Produto {
    public static int quantidadeProdutos = 0;
    
    private String nome;
    private double preco;
    
    public Produto(String nome, double preco){
        this.nome = nome;
        this.preco = preco;
        quantidadeProdutos = quantidadeProdutos + 1;
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setPreco(double preco){
        if(preco <= 0){
            System.out.println("Preço errado");
            this.preco = 9999;
        }
        else{
            this.preco = preco;
        }
    }
    
    public double getPreco(){
        return preco;
    }
}
