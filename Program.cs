Album albumDoQueen = new Album();
albumDoQueen.Name = "A night at the opera";

Music music1 = new Music();
music1.Name = "Love of my life";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Bohemian Rhapsody";
music2.Duration = 354;

albumDoQueen.AddMusic(music1);
albumDoQueen.AddMusic(music2);
albumDoQueen.ShowMusicsFromAlgum();