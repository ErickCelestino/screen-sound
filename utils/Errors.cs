namespace ScreenSound.Utils;

internal class Errors
{
    public static void ShowMessageNotFoundBand(string bandName)
    {
        Console.WriteLine($"\nA banda {bandName} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}