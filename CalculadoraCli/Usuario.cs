class Usuario
{
    public string? Nome { get; set; }
    public char? Sexo { get; set; }

    private string ObterNome()
    {
        Console.Write("\nPor gentileza, informe seu nome: ");
        string nome = Console.ReadLine()!;

        return nome;
    }

    private char defineSexo()
    {
        Console.Write("\nQual é o seu gênero?(M/F): ");
        string sexoString = Console.ReadLine()!;
        sexoString = sexoString.ToLower();
        char[] sexoCharList = sexoString.ToCharArray();

        return sexoCharList[0];
    }

    private Tuple<bool,char> VerificaSexo(char sexo)
    {
        if (sexo == 'm' || sexo == 'f')
        {
            var okResponseTuple = new Tuple<bool, char>(true, sexo);
            return okResponseTuple;
        }

        Tuple<bool, char> failResponseTuple = new Tuple<bool, char>(false, sexo);
        
        return failResponseTuple;
    }

    public Usuario()
    {
        Console.Clear();
        
        string nome = ObterNome();
        char sexo = defineSexo();
        
        var testSexoTuple = VerificaSexo(sexo);

        while (!testSexoTuple.Item1)
        {
            Console.WriteLine("Por favor informe uma opção válida para o gênero...");
    
            sexo = defineSexo();
            testSexoTuple = VerificaSexo(sexo);
        }

        this.Nome = nome;
        this.Sexo = sexo;
    }
}   