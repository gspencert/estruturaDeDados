package src.service;

import src.model.Aluno;
import src.repository.AlunoRepository;
import java.util.List;

// Classe que contém as regras do sistema
public class AlunoService {

    // Instancia o repositório
    AlunoRepository repo = new AlunoRepository();

    // Lista todos os alunos
    public void listar() {
        List<Aluno> alunos = repo.listarAlunos();

        // Percorre a lista e imprime cada aluno
        for (Aluno a : alunos) {
            System.out.println(a);
        }
    }

    // Busca alunos pelo nome
    public void buscarPorNome(String nome) {
        List<Aluno> alunos = repo.listarAlunos();

        for (Aluno a : alunos) {
            // Compara ignorando maiúsculo/minúsculo
            if (a.nome.equalsIgnoreCase(nome)) {
                System.out.println(a);
            }
        }
    }

    // Busca alunos pelo ano de ingresso
    public void buscarPorAno(int ano) {
        List<Aluno> alunos = repo.listarAlunos();

        for (Aluno a : alunos) {
            if (a.anoIngresso == ano) {
                System.out.println(a);
            }
        }
    }

    // Conta quantos alunos entraram em determinado ano
    public void contarPorAno(int ano) {
        List<Aluno> alunos = repo.listarAlunos();

        int total = 0;

        for (Aluno a : alunos) {
            if (a.anoIngresso == ano) {
                total++;
                System.out.println(a);
            }
        }

        // Mostra o total encontrado
        System.out.println("Total: " + total);
    }
}