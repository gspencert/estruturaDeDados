package src.repository;

import src.model.Aluno;
import java.io.*;
import java.util.*;

// Classe responsável por acessar o arquivo CSV
public class AlunoRepository {

    // Método que lê o arquivo e retorna uma lista de alunos
    public List<Aluno> listarAlunos() {

        // Lista que vai armazenar os alunos
        List<Aluno> lista = new ArrayList<>();

        try {
            // Abre o arquivo CSV
            BufferedReader br = new BufferedReader(
                new FileReader("src/repository/dados.csv")
            );

            String linha;
            boolean primeira = true;

            // Lê linha por linha do arquivo
            while ((linha = br.readLine()) != null) {

                // Ignora o cabeçalho (primeira linha)
                if (primeira) {
                    primeira = false;
                    continue;
                }

                // Divide os dados pelo separador ","
                String[] p = linha.split(",");

                // Pega os dados de cada coluna
                String nome = p[0];
                String curso = p[1];
                String sexo = p[2];
                int ano = Integer.parseInt(p[3]);

                // Cria um objeto Aluno e adiciona na lista
                lista.add(new Aluno(nome, curso, sexo, ano));
            }

            // Fecha o arquivo
            br.close();

        } catch (Exception e) {
            // Caso ocorra erro
            System.out.println("Erro ao ler arquivo");
        }

        // Retorna a lista de alunos
        return lista;
    }
}