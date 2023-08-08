namespace ScreenSound.Models;

internal class Album: IAvaliation
{
    public Album(string name)
    {
        Name = name;
    }
    private readonly List<Music> musics = new();
    private List<Avaliation> notes = new();
    public string Name {get;}
    public int TotalDuration => musics.Sum(m => m.Duration);
    public List<Music> Musics => musics;

    public double Average
    {
        get
        {
            if(notes.Count == 0) return 0;
            else return notes.Average(a => a.Note);
        }
    }

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

    public void AddNote(Avaliation note)
    {
        notes.Add(note);
    }
}