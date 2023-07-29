List<string> bandList = new List<string>{"U2", "Calipso", "The Beatles"};

void ShowLogo()
{
    string  welcome = "Welcome to Screen Sound";
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

    Console.WriteLine(welcome);
}

void ShowOptionsMenu()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int chosenNumericOption = int.Parse(chosenOption);
    switch (chosenNumericOption)
    {
        case 1: RegisterBand();
            break;
        case 2: ShowRegisteredBands();
            break;
        case 3: Console.WriteLine("Você digitou a opção " + chosenOption);
            break;
        case 4: Console.WriteLine("Você digitou a opção " + chosenOption);
            break;
        case -1: Console.WriteLine("Tchau tchau =)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de bandas ");
    Console.WriteLine("*******************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);
    Console.Write($"A banda {bandName} foi registrar com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ShowOptionsMenu();
}

void ShowRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    for (int i = 0; i< bandList.Count; i++)
    {
        Console.WriteLine($"Banda: {bandList[i]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ShowOptionsMenu();
}
ShowOptionsMenu();
