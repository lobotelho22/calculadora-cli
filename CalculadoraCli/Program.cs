class Program
{
    static void Main(string[] args)
    {
        Message inicio = new Message();
        inicio.Welcome();
        inicio.Instrucoes();

        inicio.MainMenu();

        ConsoleKeyInfo selecao = Console.ReadKey();
        while(selecao.Key != ConsoleKey.Q) {
            if (selecao.Key == ConsoleKey.D1 ) {
                Console.Clear();
                inicio.Calcular();
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
}
