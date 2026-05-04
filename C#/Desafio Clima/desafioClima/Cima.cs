using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/// Representa um registro climático
class Clima
{
    /// Dados básicos
    public string Ano;
    public string Mes;
    public string Temperatura;
    public string Precipitacao;

    /// Meses por estação
    public static string[] meses_verao = { "Dezembro", "Janeiro", "Fevereiro", "Março" };
    public static string[] meses_inverno = { "Agosto", "Setembro", "Outubro", "Novembro" };
    public static string[] meses_outono = { "Abril", "Maio", "Junho", "Julho" };

    /// Construtor
    public Clima(string ano, string mes, string temperatura, string precipitacao)
    {
        Ano = ano;
        Mes = mes;
        Temperatura = temperatura;
        Precipitacao = precipitacao;
    }

    /// Retorna os dados formatados
    public override string ToString()
    {
        return $"Ano: {Ano} | Mes: {Mes} | Temperatura: {Temperatura} | Precipitação: {Precipitacao}";
    }

    /// Lê CSV e monta lista
    public static List<Clima> getDadosCsv(string nome_arquivo, List<Clima> dados_csv)
    {
        string[] linhas = File.ReadAllLines(nome_arquivo);

        for (int i = 1; i < linhas.Length; i++)
        {
            string[] partes = linhas[i].Split(',');

            Clima clima = new Clima(partes[0], partes[1], partes[2], partes[3]);
            dados_csv.Add(clima);
        }
        return dados_csv;
    }

    /// Filtra por temperatura
    public static List<Clima> FiltroPorTemperatura(List<Clima> lista, string temperatura)
    {
        List<Clima> resultado = new List<Clima>();

        foreach (Clima c in lista)
            if (c.Temperatura == temperatura)
                resultado.Add(c);

        return resultado;
    }

    /// Conta registros por estação
    public static int ContarPorEstacao(List<Clima> lista, string[] meses)
    {
        int count = 0;

        foreach (Clima c in lista)
            if (meses.Contains(c.Mes))
                count++;

        return count;
    }

    /// Mostra lista no console
    public static void ExibeLista(List<Clima> lista)
    {
        foreach (Clima c in lista)
            Console.WriteLine(c);

        Console.WriteLine("-----------------------------------------------------------------------");
    }
}