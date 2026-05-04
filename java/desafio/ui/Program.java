package src.ui;

import java.util.Scanner;
import src.service.AlunoService;

// Classe principal (onde o programa roda)
public class Program {

    public static void main(String[] args) {

        // Scanner para ler dados do usuário
        Scanner sc = new Scanner(System.in);

        // Cria o service
        AlunoService service = new AlunoService();

        int opcao;

        // Loop do menu
        do {
            System.out.println("\n1 - Listar");
            System.out.println("2 - Buscar por nome");
            System.out.println("3 - Buscar por ano");
            System.out.println("4 - Contar por ano");
            System.out.println("5 - Sair");

            System.out.print("Opção: ");
            opcao = sc.nextInt();
            sc.nextLine(); // limpa buffer

            // Opção 1: listar alunos
            if (opcao == 1) {
                service.listar();
            }

            // Opção 2: buscar por nome
            else if (opcao == 2) {
                System.out.print("Nome: ");
                String nome = sc.nextLine();
                service.buscarPorNome(nome);
            }

            // Opção 3: buscar por ano
            else if (opcao == 3) {
                System.out.print("Ano: ");
                int ano = sc.nextInt();
                service.buscarPorAno(ano);
            }

            // Opção 4: contar por ano
            else if (opcao == 4) {
                System.out.print("Ano: ");
                int ano = sc.nextInt();
                service.contarPorAno(ano);
            }

        } while (opcao != 5); // continua até escolher sair

        // Fecha o scanner
        sc.close();
    }
}