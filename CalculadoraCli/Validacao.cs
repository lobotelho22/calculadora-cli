class Validacao
{
    public static ConsoleKeyInfo ValidarOperacao(ConsoleKeyInfo operacao)
    {
        ConsoleKey[] validOperation = { ConsoleKey.A, ConsoleKey.S, ConsoleKey.M, ConsoleKey.D };
        
        while (!validOperation.Contains(operacao.Key))
        {
            Console.WriteLine("\nInforme uma operação válida!");
            Console.WriteLine(@"(A-Adição / S-Subtração / M-Multiplicação / D-Divisão): ");
            operacao = Console.ReadKey();
        }

        return operacao;
    }

    public static ConsoleKeyInfo opcaoParcela(ConsoleKeyInfo opcaoSelecionada)
    {
            ConsoleKey[] opcoesValidas = {ConsoleKey.D1, ConsoleKey.D2};
    
            while (!opcoesValidas.Contains(opcaoSelecionada.Key))
            {
                Console.Clear();
            
                Console.WriteLine("\nSelecione uma opção válida:");
                Console.WriteLine("Você deseja utilizar o valor em qual parcela?");
                Console.WriteLine("\t1 - Primeira Parcela");
                Console.WriteLine("\t2 - Segunda Parcela");
            
                opcaoSelecionada = Console.ReadKey(true);
            }

            return opcaoSelecionada;
    }

}
