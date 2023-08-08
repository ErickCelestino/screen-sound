using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit: Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        Console.WriteLine("Tchau tchau :) ");   
    }
}