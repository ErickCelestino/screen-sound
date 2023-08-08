namespace ScreenSound.Models;

internal interface IAvaliation
{
    void AddNote(Avaliation note);
    double Average { get; }
}