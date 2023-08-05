namespace ScreenSound.Models;
internal class Band 
{
    public Band(string name)
    {
        Name = name;
    }
    private readonly List<Album> Albums = new();
    private readonly List<Avaliation> Notes = new();
    public double Average
    {
        get
        {
            if(Notes.Count == 0) return 0;
            else return Notes.Average(a => a.Note);
        }
    }
    public string Name {get;}

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AddNote(Avaliation note)
    {
        Notes.Add(note);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (Album album in Albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }
}