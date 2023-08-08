using ScreenSound.Models;
using ScreenSound.Menus;

Band ira = new("Ira!");
ira.AddNote(new Avaliation(10));
ira.AddNote(new Avaliation(0));
ira.AddNote(new Avaliation(5));
Band beatles = new("The Beatles!");
beatles.AddNote(new Avaliation(2));
beatles.AddNote(new Avaliation(10));

Dictionary<string, Band> RegisteredBands = new()
{
    { ira.Name, ira },
    { "The Beatles", beatles }
};

void ShowOptionsMenu()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para registrar álbum da banda");
    Console.WriteLine("Digite 6 para exibir detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int chosenNumericOption = int.Parse(chosenOption);
    switch (chosenNumericOption)
    {
        case 1:
            MenuBandRegister register = new();
            register.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 2:
            MenuShowRegisteredBands registeredBand = new();
            registeredBand.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 3:
            MenuBandAvaliation avaliation = new();
            avaliation.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 4:
            MenuShowAverage average = new();
            average.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 5:
            MenuRegisterAlbum album = new();
            album.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 6:
            MenuShowDetails showDetails = new(); 
            showDetails.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case -1:
            Console.WriteLine("Tchau tchau =)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void ShowLogo()
{
    Console.Clear();
    string welcome = "Welcome to Screen Sound 2.0!";
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


ShowOptionsMenu();
