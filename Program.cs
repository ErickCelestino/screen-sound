string  welcome = "Welcome to Screen Sound";

void ShowWelomeMessage(string messagem)
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(messagem);
}

void ShowOptionsMenu()
{
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
        case 1: Console.WriteLine("Você digitou a opção " + chosenOption);
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

ShowWelomeMessage(welcome);
ShowOptionsMenu();
