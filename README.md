# LINQDb
i passi necessari alla creazione del progetto con dotnet new console

 1. si crea una nuova cartella e gli si da un nome
 2. si apre la cartella con visual studio e si apre un nuovo terminale
 3. con il codice dotnet new console si creano due file csproject e program.cs

il codice necessario per visualizzare una tabella dei database è :


```
 using SQLite;


SQLiteConnection cn1 = new SQLiteConnection("chinook.db");



var tblArtists = cn1.Query<Artist>("select * from artists");


Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");

//linguaggio LINQ

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
 
 ```
