String option;

while (true)
{
   // Console.Clear();// vai limpar o menu
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
}

switch (option)
{
    case "1":
        Console.WriteLine("Cadastrar cliente");
    case "2":
        Console.WriteLine("Buscar cliente");
    case "3":
        Console.WriteLine("Apagar cliente");
    case "4":
        Console.WriteLine("Encerrar");
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Opção inálida!");
        break;
}