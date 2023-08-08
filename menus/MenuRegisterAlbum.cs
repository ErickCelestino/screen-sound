using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
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
    }
}