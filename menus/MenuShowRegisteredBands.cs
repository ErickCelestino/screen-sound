using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowRegisteredBands : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        Menu.ShowTitleForOption("Exibindo todas as bandas registradas");
        foreach (string band in RegisteredBands.Keys)
        {
            Console.WriteLine($"Banda: {band}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
    }
}