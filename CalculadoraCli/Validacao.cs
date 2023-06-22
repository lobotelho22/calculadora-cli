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
}