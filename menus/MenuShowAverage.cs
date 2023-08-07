using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuShowAverage : Menu
{
    public void Execute(Dictionary<string, Band> RegisteredBands)
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
        }
        else
        {
            Errors.ShowMessageNotFoundBand(bandName);
        }
    }
}