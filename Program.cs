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

Dictionary<int, Menu> options = new()
{
    {1, new MenuBandRegister()},
    {2, new MenuShowRegisteredBands()},
    {3, new MenuBandAvaliation()},
    {4, new MenuShowAverage()},
    {5, new MenuRegisterAlbum()},
    {6, new MenuShowDetails()},
    {7, new MenuAlbumAvaliation()},
    {-1, new MenuExit()} 
};

void ShowOptionsMenu()
{
    Menu.ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para registrar álbum da banda");
    Console.WriteLine("Digite 6 para exibir detalhes de uma banda");
    Console.WriteLine("Digite 7 para avaliar álbum");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string chosenOption = Console.ReadLine()!;
    int chosenNumericOption = int.Parse(chosenOption);
    if (options.ContainsKey(chosenNumericOption))
    {
        Menu menuTobeDisplayed = options[chosenNumericOption];
        menuTobeDisplayed.Execute(RegisteredBands);
        if (chosenNumericOption > 0) ShowOptionsMenu();
    } else {
        Console.WriteLine("Opção inválida");
    }
}

ShowOptionsMenu();
