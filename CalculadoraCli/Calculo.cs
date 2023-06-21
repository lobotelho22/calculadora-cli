class Calculo
{
    private decimal parcela01;
    private decimal parcela02;
    public static List<Tuple<string, decimal>> resultados = new List<Tuple<string, decimal>>(); 

    public Calculo(decimal userParcela01, decimal userParcela02)
    {
        this.parcela01 = userParcela01;
        this.parcela02 = userParcela02;
    }

    private void adicionaHistoricoResultados(decimal resultado, string operacao)
    {
        string operacaoDone = $"{this.parcela01} {operacao} {this.parcela02}";
        var historicoResultado = new Tuple<string, decimal> (operacaoDone, resultado);
        resultados.Add(historicoResultado);
    }

    public static void obterHistorico() {
        Tuple<string, decimal>[] resultArr = resultados.ToArray();
        if (resultArr.Length > 0) {
            foreach (Tuple<string, decimal> T in resultArr) {
                Console.WriteLine(T.Item1);
                Console.WriteLine(T.Item2);
            }
        }
    }

    public decimal Soma() {
        decimal resultado = this.parcela01 + this.parcela02;
        adicionaHistoricoResultados(resultado, "+");
        return resultado;
    }

    public decimal Subtracao() {
        decimal resultado = this.parcela01 - this.parcela02;
        adicionaHistoricoResultados(resultado, "-");
        return resultado;
    }

    public decimal Multiplicacao() {
        decimal resultado = this.parcela01 * this.parcela02;
        adicionaHistoricoResultados(resultado, "*");
        return resultado;
    }

    public (decimal?, string) Divisao() {
        if (this.parcela02 == 0) { return (null, "Dividir por zero, ô mané?"); }
        decimal resultado = this.parcela01 / this.parcela02;
        adicionaHistoricoResultados(resultado, "/");
        return (resultado, "");
    }
}