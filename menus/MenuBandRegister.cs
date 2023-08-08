using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuBandRegister : Menu
{
    public override void Execute(Dictionary<string, Band> RegisteredBands)
    {
        base.Execute(RegisteredBands);
        ShowTitleForOption("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string bandName = Console.ReadLine()!;
        Band band = new(bandName);
        RegisteredBands.Add(bandName, band);
        var client = new OpenAIAPI("Coloque seu token aqui");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {bandName} em 1 parágrafo. Adote um estilo informal.");

        string response = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        band.Resume = response;

        Console.Write($"A banda {bandName} foi registrar com sucesso");
        //Thread.Sleep(2000);
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}