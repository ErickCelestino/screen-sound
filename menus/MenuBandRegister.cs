using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuBandRegister: Menu
{
    public void Execute(Dictionary<string, Band> RegisteredBands)
    {
        Console.Clear();
        ShowTitleForOption("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string bandName = Console.ReadLine()!;
        Band band = new(bandName);
        RegisteredBands.Add(bandName, band);
        Console.Write($"A banda {bandName} foi registrar com sucesso");
        Thread.Sleep(2000);
    }
}