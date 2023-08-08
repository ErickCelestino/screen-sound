using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class Menu
{
    public static void ShowLogo()
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
    public static void ShowTitleForOption(string title)
    {
        int quantityForLyrics = title.Length;
        string asteriscs = string.Empty.PadLeft(quantityForLyrics, '*');
        Console.WriteLine(asteriscs);
        Console.WriteLine(title);
        Console.WriteLine(asteriscs + "\n");
    }

    public virtual void Execute(Dictionary<string, Band> RegisteredBands)
    {
        Console.Clear();
    }
}