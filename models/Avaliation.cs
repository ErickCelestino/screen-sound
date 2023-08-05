namespace ScreenSound.Models;

internal class Avaliation 
{
    public Avaliation(int note)
    {
        Note = note;
    }
    public int Note { get; }

    static public Avaliation Parse(string text)
    {
        int note = int.Parse(text);
        return new Avaliation(note);
    }
}