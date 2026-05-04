package src.model;

// Classe que representa um aluno
public class Aluno {

    // Atributos do aluno
    public String nome;
    public String curso;
    public String sexo;
    public int anoIngresso;

    // Construtor: usado para criar um aluno com dados
    public Aluno(String nome, String curso, String sexo, int anoIngresso) {
        this.nome = nome;
        this.curso = curso;
        this.sexo = sexo;
        this.anoIngresso = anoIngresso;
    }

    // Método que define como o objeto será exibido no console
    @Override
    public String toString() {
        return "Nome: " + nome +
               " | Curso: " + curso +
               " | Sexo: " + sexo +
               " | Ano: " + anoIngresso;
    }
}