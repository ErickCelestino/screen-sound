
void ShowLogo()
{
    string  welcome = "Welcome to Screen Sound";
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(welcome);
}

void ShowOptionsMenu()
{
    ShowLogo();
    Console.Write("\nDigite 1 para registrar uma banda");
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
        case 2: Console.WriteLine("Você digitou a opção " + chosenOption);
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
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    Console.Write($"A banda {bandName} foi registrar com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ShowOptionsMenu();
}
ShowOptionsMenu();
