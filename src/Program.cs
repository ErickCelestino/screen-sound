// Band queen = new Band("Queen");

// Album albumDoQueen = new Album("A night at the opera");

// Music music1 = new Music(queen,"Love of my life")
// {
//     Duration = 213,
//     Avaliable = true
// };


// Music music2 = new Music(queen,"Bohemian Rhapsody")
// {
//     Duration = 354,
//     Avaliable = false
// };

// albumDoQueen.AddMusic(music1);
// albumDoQueen.AddMusic(music2);
// queen.AddAlbum(albumDoQueen);

// music1.ShowTecnicalFiche();
// music2.ShowTecnicalFiche();
// albumDoQueen.ShowMusicsFromAlgum();
// queen.ShowDiscography();

Episode ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AddGuest("Erick");
ep1.AddGuest("Jovana");

Episode ep2 = new(1, "Técnicas de choro", 58);
ep2.AddGuest("Eris");
ep2.AddGuest("Jovana");

PodCast podCast = new("Podcast incrivel","Erick");
podCast.AddEpisode(ep1);
podCast.AddEpisode(ep2);

podCast.ShowDetails();