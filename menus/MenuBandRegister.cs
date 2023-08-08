using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuBandRegister: Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        ShowTitleForOption("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string bandName = Console.ReadLine()!;
        Band band = new(bandName);
        RegisteredBands.Add(bandName, band);
        Console.Write($"A banda {bandName} foi registrar com sucesso");
        Thread.Sleep(2000);
    }
}