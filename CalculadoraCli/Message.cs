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

        calcular.Executar(operacao.KeyChar.ToString().ToUpper());
    
        RetornarAoMenu();
    }

    public void ExibirHistorico() {
        Console.WriteLine("Pressione ENTER para exibir a lista do histórico de operações...");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        Calculo.obterHistorico();
        RetornarAoMenu();
    }

    private void RetornarAoMenu() {
        Console.WriteLine("Pressione ENTER para retornar ao menu principal...");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        Console.Clear();
        MainMenu();
        Console.WriteLine("\n");
        Calculo.obterHistorico();
    }
}