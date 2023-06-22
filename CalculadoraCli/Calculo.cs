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

    public static decimal ObterParcela()
    {
        decimal decimalParcela;
        string? parcela = Console.ReadLine();
        
        while(!Decimal.TryParse(parcela, out decimalParcela))
        {
            Console.Write("\nInforme um valor numérico válido: ");
            parcela = Console.ReadLine();
        }
        
        return decimalParcela;
    }

    private void adicionaHistoricoResultados(decimal resultado, string operacao)
    {
        string operacaoDone = $"{this.parcela01} {operacao} {this.parcela02}";
        var historicoResultado = new Tuple<string, decimal> (operacaoDone, resultado);
        resultados.Add(historicoResultado);
    }

    public static void obterHistorico()
    {
        Tuple<string, decimal>[] resultArr = resultados.ToArray();

        if (resultArr.Length > 0) {
            Console.WriteLine("\t Operação\t Resultado");
            Console.WriteLine("\t============\t===========");

            foreach (Tuple<string, decimal> T in resultArr)
            {
                Console.WriteLine($"\t {T.Item1}\t\t {T.Item2}");
            }

            Console.WriteLine();
        }
        else 
        {
            Console.WriteLine("Ainda não há operações no histórico\n\n\n");
        }
    }

    public static (decimal, string) recuperarValor()
    {
        Tuple<string, decimal>[] resultArr = resultados.ToArray();
        
        if (resultArr.Length > 0)
        {
            int index = resultArr.Length - 1;
            return (resultArr[index].Item2, "");
        }
        else
        {
            string semHistorico = "Ainda não há operações no histórico\n\n\n";
            return (0, semHistorico);
        }
    }

    public decimal Soma()
    {
        decimal resultado = this.parcela01 + this.parcela02;
        adicionaHistoricoResultados(resultado, "+");
        return resultado;
    }

    public decimal Subtracao()
    {
        decimal resultado = this.parcela01 - this.parcela02;
        adicionaHistoricoResultados(resultado, "-");
        return resultado;
    }

    public decimal Multiplicacao()
    {
        decimal resultado = this.parcela01 * this.parcela02;
        adicionaHistoricoResultados(resultado, "*");
        return resultado;
    }

    public (decimal?, string) Divisao()
    {
        if (this.parcela02 == 0) { return (null, "Não é possível dividir por zero."); }
        
        decimal resultado = this.parcela01 / this.parcela02;
        adicionaHistoricoResultados(resultado, "/");
        return (resultado, "");
    }

    public void Executar(string operacao)
    {
        decimal resultado;

        switch (operacao)
        {
            case "A":
                resultado = Soma();
                Console.WriteLine("Pressione ENTER para ver o resultado...\n");

                while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}

                Console.WriteLine(resultado);
                break;

            case "S":
                resultado = Subtracao();
                Console.WriteLine("Pressione ENTER para ver o resultado...\n");
                
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
                
                Console.WriteLine(resultado);
                break;

            case "M":
                resultado = Multiplicacao();
                Console.WriteLine("Pressione ENTER para ver o resultado...\n");
                
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
                
                Console.WriteLine(resultado);
                break;

            case "D":
                (decimal?, string) resultadoDiv = Divisao();
                Console.WriteLine("Pressione ENTER para ver o resultado...\n");
                
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}

                string quociente = (resultadoDiv.Item1 == null) ? resultadoDiv.Item2 : $"{resultadoDiv.Item1}";
                                
                Console.WriteLine(quociente);
                
                break;
        }
    }
}
