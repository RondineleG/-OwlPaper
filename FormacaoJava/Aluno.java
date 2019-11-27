package formacaojava;

public class Aluno extends Pessoa{
    String curso;
    double mensalidade;
    int semestre;
    
    public Aluno(String nome, int codigoPessoa, int idade, String curso, double mensalidade, int semestre){
        super(nome, codigoPessoa, idade);
        this.curso = curso;
        this.mensalidade = mensalidade;
        this.semestre = semestre;
    }
}
