namespace ScreenSound.Menus;

internal class Menu
{
    public static void ShowTitleForOption(string title)
    {
        int quantityForLyrics = title.Length;
        string asteriscs = string.Empty.PadLeft(quantityForLyrics, '*');
        Console.WriteLine(asteriscs);
        Console.WriteLine(title);
        Console.WriteLine(asteriscs + "\n");
    }
}