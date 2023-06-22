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

        Console.WriteLine($"Essa é uma calculadora CLI, bem");
        Console.WriteLine($"simples, para as quatro operações");
        Console.WriteLine($"\nÉ algo rudimentar, para treino");
        Console.WriteLine($"das minhas habilidades em C# e POO.");
        Console.WriteLine($"\nObrigado pela visita! :)");

        Console.WriteLine($"===============================");

        Console.WriteLine("\nPressione ENTER para seguir...");

        while(Console.ReadKey(true).Key != ConsoleKey.Enter) {};

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

        operacao = Validacao.ValidarOperacao(operacao);

        Console.WriteLine("\nInforme a segunda parcela da operação: ");
        decimal parcela02 = Convert.ToDecimal(Console.ReadLine());

        Calculo calcular = new Calculo(parcela01, parcela02);

        calcular.Executar(operacao.KeyChar.ToString().ToUpper());
    
        RetornarAoMenu();
    }

    public void ExibirHistorico() {
        Console.WriteLine("Pressione ENTER para exibir a lista do histórico de operações...");
        Console.WriteLine();

        while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        
        Calculo.obterHistorico();
        RetornarAoMenu();
    }

    public void RecuperarHistorico() {
        (decimal, string) valorHistorico = Calculo.recuperarValor();
        if (valorHistorico.Item2 != ""){
            Console.WriteLine(valorHistorico.Item2);
            RetornarAoMenu();
        } else {
            decimal parcelaRecuperada = valorHistorico.Item1;
            Console.WriteLine($"O valor recuperado é {parcelaRecuperada}");
            Console.WriteLine("Você deseja utilizar o valor em qual parcela?");
            Console.WriteLine("\t1 - Primeira Parcela");
            Console.WriteLine("\t2 - Segunda Parcela");
            ConsoleKeyInfo opcaoSelecionada = Console.ReadKey(true);
            ConsoleKey[] opcoesValidas = {ConsoleKey.D1, ConsoleKey.D2};
            while (!opcoesValidas.Contains(opcaoSelecionada.Key)) {
                Console.Clear();
                Console.WriteLine("\nSelecione uma opção válida:");
                Console.WriteLine("Você deseja utilizar o valor em qual parcela?");
                Console.WriteLine("\t1 - Primeira Parcela");
                Console.WriteLine("\t2 - Segunda Parcela");
                opcaoSelecionada = Console.ReadKey(true);
            }
                if (opcaoSelecionada.KeyChar == '1') {
                    Console.Clear();
                    Console.WriteLine($"Primeira parcela: {parcelaRecuperada}");
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

                Calculo calcular = new Calculo(parcelaRecuperada, parcela02);

                calcular.Executar(operacao.KeyChar.ToString().ToUpper());

                }
                if (opcaoSelecionada.KeyChar == '2') {
                    Console.Clear();
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
                    Console.WriteLine($"\nSegunda parcela: {parcelaRecuperada}");

                    Calculo calcular = new Calculo(parcela01, parcelaRecuperada);

                    calcular.Executar(operacao.KeyChar.ToString().ToUpper());
                }

            RetornarAoMenu();
        }
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