//Prøve eksamen 29042025 Patrick Christiansen



// Opret en liste af Album-objekter


using prøveeksamen_29042025;

List<Album> albums = new List<Album>();


albums.Add(new Album("9781779505910", 2021, "Superman, the man of steal", "John Byrne", 10000));
albums.Add(new Album("8756242190", 1989, "Tintin og alfa-kunsten", "Hergés", 12000));
albums.Add(new Album("9780785124986", 2007, "Spider-Man: Birth of Venom", "Todd McFarlane", 8000));


//udskriver alle album
foreach (var album in albums)
{
    Console.WriteLine($"Titel: {album.Titel}, Tegner: {album.TegnerNavn}, År: {album.Udgivelsesår}");
}

//finder tegneserie af Hergés før 1990
bool found = false;
foreach (var album in albums)
{
    if (album.Udgivelsesår < 1990 && album.TegnerNavn == "Hergés")
    {
        Console.WriteLine("Titel: " + album.Titel);
        Console.WriteLine("Tegner: " + album.TegnerNavn);
        Console.WriteLine("Udgivelsesår: " + album.Udgivelsesår);
        Console.WriteLine("ISBN: " + album.Isbn);
        Console.WriteLine("Antal produceret: " + album.AntalProduceret);
        Console.WriteLine("-----------------------------");
        found = true;
    }
    if (!found)
    {
        Console.WriteLine("*** Ikke fundet ***");
    }
}



//Opgave 3.3
// opgave 3.3.1

//forbobler tal og udskriver det 5 gange
int tal = 2;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(tal);
    tal = tal * 2;

}


// opgave 3.3.2

// Opgave 3.3.2

//udskriver ulige tal fra -10 til -20

for (int tallet = -11; tallet > -20; tallet -= 2)
{
    Console.WriteLine(tallet);
}


