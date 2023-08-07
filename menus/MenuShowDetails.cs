using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuShowDetails: Menu
{

    public void Execute(Dictionary<string, Band> RegisteredBands)
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
        }
        else
        {
            Errors.ShowMessageNotFoundBand(bandName);
        }
    }
}