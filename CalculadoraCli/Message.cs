class Message
{
    public Usuario? user;

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
}