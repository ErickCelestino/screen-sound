namespace ScreenSound.Models;
internal class PodCast 
{
    private readonly List<Episode>  Episodes = new();
    public PodCast(string name, string host)
    {
        Name = name;
        Host = host;
    }
    public string Name { get; }

    public string Host { get; }
    
    public int TotalEpisodes => Episodes.Count;

    public void AddEpisode(Episode episode)
    {
        Episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} apresentado por {Host}\n");
        foreach(Episode episode in Episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Resume);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodes} de espisódios.");
    }
}