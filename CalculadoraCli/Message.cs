class Message
{
    private Usuario? user;

    public Message()
    {
        Console.Clear();
        this.user = new Usuario();
    }

    public void Welcome()
    {
        Console.Clear();
        string welcome = (this.user!.Sexo == 'm')
            ? $"Bem-Vindo, {this.user.Nome}"
            : $"Bem-Vinda, {this.user.Nome}";
        Console.WriteLine($"===============================");
        Console.WriteLine($"\t{welcome}");
        Console.WriteLine($"===============================");
        Console.WriteLine("\n");
        Console.WriteLine($"Essa é uma calculadora CLI, bem");
        Console.WriteLine($"simples, para as quatro operações");
        Console.WriteLine($"\nÉ algo rudimentar, para treino");
        Console.WriteLine($"das minhas habilidades em C# e POO.");
        Console.WriteLine($"\nObrigado pela visita! :)");
        Console.WriteLine("\nPressione ENTER para seguir...");
        while(Console.ReadKey().Key != ConsoleKey.Enter) {};
        Console.Clear();
    }

    public void Instrucoes()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine($"{this.user!.Nome}, a calculadora realiza as quatro operações fundamentais.");
        Console.WriteLine("Você será consultado para informar um valor numérico Real,");
        Console.WriteLine("Depois você informará um caractere para representar a operação desejada:");
        Console.WriteLine("\tA\t-\tAdição");
        Console.WriteLine("\tS\t-\tSubtração");
        Console.WriteLine("\tM\t-\tMultiplicação");
        Console.WriteLine("\tD\t-\tDivisão");
        Console.WriteLine("Por fim, informe um segundo número para realizar o cálculo.");
        Console.WriteLine("O resultado será informado na seqência.");
        Console.WriteLine("\nPressione ENTER para seguir...");
        while(Console.ReadKey().Key != ConsoleKey.Enter) {};
        Console.Clear();       
    }

    public void MainMenu()
    {
        Console.WriteLine("Digite 1:\tRealizar Cálculo");
        Console.WriteLine("Digite 2:\tRecuperar o Último Valor Para Novo Cálculo");
        Console.WriteLine("Digite 3:\tRecuperar o Histórico de Operações");
        Console.WriteLine("Digite Q:\tSaída da Calculadora");
        ConsoleKeyInfo selecao = Console.ReadKey();
        while(selecao.Key != ConsoleKey.Q) {
            if (selecao.Key == ConsoleKey.D1 ) {
                Console.Clear();
                Calcular();
                selecao = Console.ReadKey();
            }
            else if (selecao.Key == ConsoleKey.D2) {
                Console.WriteLine("\nDOIS!");
                selecao = Console.ReadKey();
            }
            else if (selecao.Key == ConsoleKey.D3) {
                Console.WriteLine("\nTRÊS!");
                selecao = Console.ReadKey();
            }
            else {
                Console.WriteLine("");
                selecao = Console.ReadKey();
            }
        }
        Console.Clear();
    }

    public void Calcular()
    {
        Console.Write("Informe a primeira parcela da operação: ");
        decimal parcela01 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a Operação desejada");
        Console.WriteLine(@"(A-Adição / S-Subtração / M-Multiplicação / D-Divisão): ");
        ConsoleKeyInfo operacao = Console.ReadKey();
        ConsoleKey[] validOperation = { ConsoleKey.A, ConsoleKey.S, ConsoleKey.M, ConsoleKey.D };
        while (!validOperation.Contains(operacao.Key)) {
            Console.WriteLine("\nInforme uma operação válida!");
            Console.WriteLine(@"(A-Adição / S-Subtração / M-Multiplicação / D-Divisão): ");
            operacao = Console.ReadKey();
        }
        Console.WriteLine("\nInforme a segunda parcela da operação: ");
        decimal parcela02 = Convert.ToDecimal(Console.ReadLine());

        Calculo calcular = new Calculo(parcela01, parcela02);

        switch (operacao.KeyChar.ToString().ToUpper())
        {
            case "A":
                decimal resultado = calcular.Soma();
                Console.WriteLine(resultado);
                break;
            default:
                Console.WriteLine("Yeah!");
                break;
        }
    }
}