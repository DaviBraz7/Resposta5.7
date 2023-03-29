using System;

class Program {
    static void Main(string[] args) {
        // Faturamento mensal de cada estado
        double faturamentoSP = 67836.43;
        double faturamentoRJ = 36678.66;
        double faturamentoMG = 29229.88;
        double faturamentoES = 27165.48;
        double faturamentoOutros = 19849.53;

        // Cálculo do valor total mensal da distribuidora
        double valorTotalMensal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Cálculo do percentual de representação de cada estado
        Console.WriteLine("Percentual de representação de cada estado:");
        Console.WriteLine("SP: " + ((faturamentoSP / valorTotalMensal) * 100.0).ToString("F2") + "%");
        Console.WriteLine("RJ: " + ((faturamentoRJ / valorTotalMensal) * 100.0).ToString("F2") + "%");
        Console.WriteLine("MG: " + ((faturamentoMG / valorTotalMensal) * 100.0).ToString("F2") + "%");
        Console.WriteLine("ES: " + ((faturamentoES / valorTotalMensal) * 100.0).ToString("F2") + "%");
        Console.WriteLine("Outros: " + ((faturamentoOutros / valorTotalMensal) * 100.0).ToString("F2") + "%");

        Console.ReadKey();
    }
}
