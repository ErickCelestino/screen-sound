using ScreenSound.Models;
using ScreenSound.Utils;

namespace ScreenSound.Menus;

internal class MenuBandAvaliation : Menu
{
    public void Execute(Dictionary<string, Band> RegisteredBands)
    {
        Console.Clear();
        ShowTitleForOption("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string bandName = Console.ReadLine()!;
        if (RegisteredBands.ContainsKey(bandName))
        {
            Band band = RegisteredBands[bandName];
            Console.Write($"Qual a nota que a banda {bandName} merece: ");
            Avaliation note = Avaliation.Parse(Console.ReadLine()!);
            band.AddNote(note);
            Console.WriteLine($"\nA nota {note.Note} foi registrada com sucesso para a banda {bandName}");
            Thread.Sleep(2000);
        }
        else
        {
            Errors.ShowMessageNotFoundBand(bandName);
        };
    }

}