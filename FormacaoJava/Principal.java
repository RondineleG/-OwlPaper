package formacaojava;

public class Principal {
    
    public static void main(String[] args) {
        Produto cafe = new Produto("Garibaldi", 38.50);
        Produto cafe2 = new Produto("Melita", 10.00);
        Produto teste = new Produto("batata", 1.99);
        System.out.println(cafe.getNome());
        System.out.println(cafe2.getNome());
        System.out.println(Produto.quantidadeProdutos); 
        Pessoa aluno = new Aluno("joao", 12, 24, "", 2, 2);
        System.out.println(aluno.getNome());
    }
    
}
