using SQLite;

SQLiteConnection cn1 = new SQLiteConnection("chinook.db");


var tblArtists = cn1.Query<Artist>("select * from artists");

Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");


// utilizzo linguaggio LINQ

tblArtists = tblArtists.OrderByDescending(x=>x.Name).ToList();
foreach(var artista in tblArtists)
{
    Console.WriteLine($"{artista.Name}");
}




public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}
}
