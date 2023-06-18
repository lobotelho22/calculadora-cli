class Message
{
    public void Welcome()
    {
        Console.Clear();

        Usuario user = new Usuario();

        Console.Clear();
        string welcome = (user.Sexo == 'm')
            ? $"Bem-Vindo, {user.Nome}"
            : $"Bem-Vinda, {user.Nome}";
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
}