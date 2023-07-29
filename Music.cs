// Nome
// Artista
// Duração
// Disponível
class Music
{
    public string name;
    public string artist;
    public int duration;
    public bool avaliable;

    public void ShowTecnicalFiche()
    {
        string avaliableCard;
        if(avaliable) {
            avaliableCard = "Diponivel no plano";
        } else {
             avaliableCard = "Adquira o plano Plus+";
        }

        Console.WriteLine($@"
        Nome: {name},
        Artista: {artist},
        Duração: {duration}
        {avaliableCard}
        ");
    }
}
