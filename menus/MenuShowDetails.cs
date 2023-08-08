using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuShowDetails: Menu
{

    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        ShowTitleForOption("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];
            Console.WriteLine(band.Resume);
            Console.WriteLine($"\nA média da banda {bandName} é {band.Average}");
            Console.WriteLine("\nDiscografia:");
            foreach(Album album in band.Albums)
            {
                Console.WriteLine($"{album.Name} -> {album.Average}");
            }
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