using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuAlbumAvaliation : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        ShowTitleForOption("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];
            Console.Write("Agora digite o título do álbum: ");
            string albumTitle = Console.ReadLine()!;
            if (band.Albums.Any(a => a.Name.Equals(albumTitle)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumTitle));
                Console.Write($"Qual a nota que o álbum {albumTitle} merece: ");
                Avaliation note = Avaliation.Parse(Console.ReadLine()!);
                album.AddNote(note);
                Console.WriteLine($"\nA nota {note.Note} foi registrada com sucesso para ao album {albumTitle} da banda {bandName}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Errors.ShowMessageNotFoundAlbum(albumTitle);
            }

        }
        else
        {
            Errors.ShowMessageNotFoundBand(bandName);
        };
    }
}