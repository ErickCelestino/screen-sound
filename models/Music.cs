namespace ScreenSound.Models;

internal class Music
{
    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }
    public string Name {get;}
    public Band Artist {get;}
    public int Duration {get; set;}
    public bool Avaliable {get; set;}
    public string ResumeDescription => $"A música {Name} partence À banda {Artist.Name}";

    public void ShowTecnicalFiche()
    {
        string avaliableCard;
        if(Avaliable) {
            avaliableCard = "Diponivel no plano";
        } else {
             avaliableCard = "Adquira o plano Plus+";
        }
        Console.WriteLine($@"
Nome: {Name},
Artista: {Artist},
Duração: {Duration}
{avaliableCard}
        ");
    }
}
