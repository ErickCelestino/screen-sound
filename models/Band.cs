namespace ScreenSound.Models;
class Band 
{
    public Band(string name)
    {
        Name = name;
    }
    private readonly List<Album> Albums = new();
    private readonly List<int> Notes = new();
    public double Average =>  Notes.Average();
    public string Name {get;}

    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AddNote(int note)
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