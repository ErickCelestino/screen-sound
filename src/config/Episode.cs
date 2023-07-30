class Episode
{
    private List<string> guests = new();
    public Episode(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }

    public int Order { get; }
    public string Title { get; }
    public int Duration { get; }
    public string Resume => $"{Order}. {Title} ({Duration} min). \nConvidados {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}