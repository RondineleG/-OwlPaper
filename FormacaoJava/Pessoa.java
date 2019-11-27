
package formacaojava;

public class Pessoa {
    private String nome;
    private int codigoDePessoa;
    private int idade;
    
    public Pessoa(String nome, int codigoPessoa, int idade){
        this.nome = nome;
        this.codigoDePessoa = codigoPessoa;
        this.idade = idade;
    }
    
    public String getNome(){
        return nome;
    }
}
