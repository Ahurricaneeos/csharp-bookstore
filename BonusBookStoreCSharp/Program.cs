// Aquisizione dati:

Console.Write("Inserisci il titolo del libro: ");
string aquiredTitle = Console.ReadLine();

Console.Write("Inserisci l'autore del libro: ");
string aquiredAuthor = Console.ReadLine();

Console.Write("Inserisci l'ISBN del libro: ");
string aquiredIsbn = Console.ReadLine();

Console.Write("Inserisci il numero di pagine del libro: ");
int aquiredPages = int.Parse(Console.ReadLine());

Console.Write("Inserisci il peso del libro: ");
int aquiredWeight = int.Parse(Console.ReadLine());

Console.Write("Inserisci la larghezza del libro: ");
float aquiredLenght = float.Parse(Console.ReadLine());

Console.Write("Inserisci la lunghezza del libro: ");
float aquiredHeight = float.Parse(Console.ReadLine());

Console.Write("Inserisci la profondità del libro: ");
float aquiredDepht = float.Parse(Console.ReadLine());

Console.Write("Inserisci la valutazione del libro: ");
float aquiredRating = float.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di recensioni del libro: ");
int aquiredReviews = int.Parse(Console.ReadLine());

Console.Write("Ha un formato kindle?");
string aquiredKindle = Console.ReadLine();

Console.Write("Ha un formato copertina flessibile?");
string aquiredFlexibleCover = Console.ReadLine();

// Stampa delle informazioni:

Console.WriteLine("-------IL LIBRO DI OGGI: " + aquiredTitle + " di " + aquiredAuthor + " -------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + aquiredIsbn);
Console.WriteLine("Numero delle pagine: " + aquiredPages + " pagine");
Console.WriteLine("Peso del libro: " + aquiredWeight + "kg");
Console.WriteLine("Dimensioni del libro: " + aquiredLenght + "cm x " + aquiredHeight + "cm x " + aquiredDepht + "cm");
Console.WriteLine(" ");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + aquiredReviews + " recensioni");
Console.WriteLine("Valutazione media: " + aquiredRating + " stelline");
Console.WriteLine("Kindle disponibile: " + aquiredKindle);
Console.WriteLine("Copertina flessibile disponibile: " + aquiredFlexibleCover);
Console.WriteLine("---------------------------------------------------------------------------");