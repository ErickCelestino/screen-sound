namespace ScreenSound.Models;
class PodCast 
{
    List<Episode> episodes = new();
    public PodCast(string name, string host)
    {
        Name = name;
        Host = host;
    }
    public string Name { get; }

    public string Host { get; }
    
    public int totalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} apresentado por {Host}\n");
        foreach(Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Resume);
        }
        Console.WriteLine($"\n\nEste podcast possui {totalEpisodes} de espisódios.");
    }
}