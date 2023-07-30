Band queen = new Band("Queen");

Album albumDoQueen = new Album("A night at the opera");

Music music1 = new Music(queen,"Love of my life");
music1.Duration = 213;

Music music2 = new Music(queen,"Bohemian Rhapsody");
music2.Duration = 354;

albumDoQueen.AddMusic(music1);
albumDoQueen.AddMusic(music2);

queen.AddAlbum(albumDoQueen);
queen.ShowDiscography();