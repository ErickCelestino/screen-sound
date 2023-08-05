using ScreenSound.Models;

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
            RegisterBand();
            break;
        case 2:
            ShowRegisteredBands();
            break;
        case 3:
            RateBand();
            break;
        case 4:
            ShowAverage();
            break;
        case 5:
            RegisterAlbum();
            break;
        case 6:
            ShowDetails();
            break;
        case -1:
            Console.WriteLine("Tchau tchau =)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegisterBand()
{
    Console.Clear();
    ShowTitleForOption("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    Band band = new(bandName);
    RegisteredBands.Add(bandName, band);
    Console.Write($"A banda {bandName} foi registrar com sucesso");
    Thread.Sleep(2000);
    ShowOptionsMenu();
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

void RateBand()
{
    // Digite qual banda deseja avaliar
    // Se a banda existir no dicionário >> atribuir uma nota
    // Senão, volta ao menu principal

    Console.Clear();
    ShowTitleForOption("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandName = Console.ReadLine()!;
    if (RegisteredBands.ContainsKey(bandName))
    {
        Band band = RegisteredBands[bandName];
        Console.Write($"Qual a nota que a banda {bandName} merece: ");
        int note = int.Parse(Console.ReadLine()!);
        band.AddNote(new Avaliation(note));
        Console.WriteLine($"\nA nota {note} foi registrada com sucesso para a banda {bandName}");
        Thread.Sleep(2000);
        ShowOptionsMenu();
    }
    else
    {
        showMessageNotFoundBand(bandName);
        ShowOptionsMenu();
    };
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
        showMessageNotFoundBand(bandName);
        ShowOptionsMenu();
    }
}
void showMessageNotFoundBand(string bandName)
{
    Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
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
        showMessageNotFoundBand(bandName);
    }

    ShowOptionsMenu();
}

void ShowDetails()
{
    Console.Clear();
    ShowTitleForOption("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string bandName = Console.ReadLine()!;
    if (RegisteredBands.ContainsKey(bandName))
    {
        Band band = RegisteredBands[bandName];
        Console.WriteLine($"\nA média da banda {bandName} é {band.Average}");

        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ShowOptionsMenu();
    }
    else
    {
        showMessageNotFoundBand(bandName);
        ShowOptionsMenu();
    }
}
ShowOptionsMenu();
