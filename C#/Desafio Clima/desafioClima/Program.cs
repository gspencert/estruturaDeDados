using System;
using System.IO;

/// Classe principal que executa a análise
class Program
{
    /// Método principal: lê CSV, filtra dados e mostra resultados
    public static void Main()
    {
        // Carrega dados do CSV
        string nome_arquivo = "dados.csv";
        List<Clima> dados_csv = new List<Clima>();
        dados_csv = Clima.getDadosCsv(nome_arquivo, dados_csv);

        // Separa por temperatura
        List<Clima> quente = Clima.FiltroPorTemperatura(dados_csv, "Quente");
        List<Clima> frio = Clima.FiltroPorTemperatura(dados_csv, "Frio");
        List<Clima> ameno = Clima.FiltroPorTemperatura(dados_csv, "Ameno");

        // Conta por estação
        int qtd_quente_verao = Clima.ContarPorEstacao(quente, Clima.meses_verao);
        int qtd_frio_verao = Clima.ContarPorEstacao(frio, Clima.meses_verao);
        int qtd_ameno_verao = Clima.ContarPorEstacao(ameno, Clima.meses_verao);

        int qtd_quente_inverno = Clima.ContarPorEstacao(quente, Clima.meses_inverno);
        int qtd_frio_inverno = Clima.ContarPorEstacao(frio, Clima.meses_inverno);
        int qtd_ameno_inverno = Clima.ContarPorEstacao(ameno, Clima.meses_inverno);

        int qtd_quente_outono = Clima.ContarPorEstacao(quente, Clima.meses_outono);
        int qtd_frio_outono = Clima.ContarPorEstacao(frio, Clima.meses_outono);
        int qtd_ameno_outono = Clima.ContarPorEstacao(ameno, Clima.meses_outono);

        // Mostra listas
        Clima.ExibeLista(quente);
        Clima.ExibeLista(frio);
        Clima.ExibeLista(ameno);

        // Resumo
        Console.WriteLine($"Quentes — Verão: {qtd_quente_verao} | Inverno: {qtd_quente_inverno} | Outono: {qtd_quente_outono}");
        Console.WriteLine($"Frios — Verão: {qtd_frio_verao} | Inverno: {qtd_frio_inverno} | Outono: {qtd_frio_outono}");
        Console.WriteLine($"Amenos — Verão: {qtd_ameno_verao} | Inverno: {qtd_ameno_inverno} | Outono: {qtd_ameno_outono}");

        // Estação mais quente
        if (qtd_quente_verao > qtd_quente_inverno && qtd_quente_verao > qtd_quente_outono)
            Console.WriteLine($"Estação mais quente: Verão — {qtd_quente_verao} registros");
        else if (qtd_quente_inverno > qtd_quente_outono)
            Console.WriteLine($"Estação mais quente: Inverno — {qtd_quente_inverno} registros");
        else
            Console.WriteLine($"Estação mais quente: Outono — {qtd_quente_outono} registros");

        // Estação mais fria
        if (qtd_frio_verao > qtd_frio_inverno && qtd_frio_verao > qtd_frio_outono)
            Console.WriteLine($"Estação mais fria: Verão — {qtd_frio_verao} registros");
        else if (qtd_frio_inverno > qtd_frio_outono)
            Console.WriteLine($"Estação mais fria: Inverno — {qtd_frio_inverno} registros");
        else
            Console.WriteLine($"Estação mais fria: Outono — {qtd_frio_outono} registros");

        // Estação mais amena
        if (qtd_ameno_verao > qtd_ameno_inverno && qtd_ameno_verao > qtd_ameno_outono)
            Console.WriteLine($"Estação mais amena: Verão — {qtd_ameno_verao} registros");
        else if (qtd_ameno_inverno > qtd_ameno_outono)
            Console.WriteLine($"Estação mais amena: Inverno — {qtd_ameno_inverno} registros");
        else
            Console.WriteLine($"Estação mais amena: Outono — {qtd_ameno_outono} registros");
    }
}