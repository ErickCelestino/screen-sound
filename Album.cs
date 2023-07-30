class Album
{
    public Album(string name)
    {
        Name = name;
    }
    private List<Music> musics = new List<Music>();
    public string Name {get;}
    public int TotalDuration => musics.Sum(m => m.Duration);

    public  void AddMusic(Music music) 
    {
        musics.Add(music);
    } 

    public void ShowMusicsFromAlgum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}");
         foreach(var music in musics)
         {
            Console.WriteLine($"Música: {music.Name}");
         }
         Console.WriteLine($"\nPara ouvir este álbum inteiro você preisa de {TotalDuration} segundos");
    }
}