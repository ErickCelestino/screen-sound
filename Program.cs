using ScreenSound.Models;
using ScreenSound.Menus;
using ScreenSound.Utils;

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
            ShowRegisteredBands();
            break;
        case 3:
            MenuBandAvaliation avaliation = new();
            avaliation.Execute(RegisteredBands);
            ShowOptionsMenu();
            break;
        case 4:
            ShowAverage();
            break;
        case 5:
            RegisterAlbum();
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


void ShowRegisteredBands()
{
    Console.Clear();
    ShowTitleForOption("Exibindo todas as bandas registradas");
    foreach (string band in RegisteredBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    ShowOptionsMenu();
}

void ShowTitleForOption(string title)
{
    int quantityForLyrics = title.Length;
    string asteriscs = string.Empty.PadLeft(quantityForLyrics, '*');
    Console.WriteLine(asteriscs);
    Console.WriteLine(title);
    Console.WriteLine(asteriscs + "\n");
}

void ShowAverage()
{
    Console.Clear();
    ShowTitleForOption("Exibir a média da banda");
    Console.Write("Digite o nome da banda para exibir média: ");
    string bandName = Console.ReadLine()!;
    if (RegisteredBands.ContainsKey(bandName))
    {
        Band band = RegisteredBands[bandName];
        Console.WriteLine($"\nA média da banda {bandName} é {band.Average}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        ShowOptionsMenu();
    }
    else
    {
        Errors.ShowMessageNotFoundBand(bandName);
        ShowOptionsMenu();
    }
}

void RegisterAlbum()
{
    Console.Clear();
    ShowTitleForOption("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string bandName = Console.ReadLine()!;
    if (RegisteredBands.ContainsKey(bandName))
    {
        Console.Write("Agora digite o título do álbum: ");
        string titleAlbum = Console.ReadLine()!;
        Band band = RegisteredBands[bandName];
        band.AddAlbum(new Album(titleAlbum));
        Console.WriteLine($"O álbum {titleAlbum} de {bandName} foi registrado com sucesso!");
        Thread.Sleep(4000);
    }
    else
    {
        Errors.ShowMessageNotFoundBand(bandName);
    }

    ShowOptionsMenu();
}
ShowOptionsMenu();
