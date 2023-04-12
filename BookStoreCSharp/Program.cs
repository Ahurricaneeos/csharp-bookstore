// Dichiarazione variabili:

string title = ("Clean Code");
string author = ("Robert C. “Uncle Bob” Martin");
string isbn = ("9780132350884");
int pages = 431;
int weight = 800;
float lenght = 17.78f;
float height = 23.37f;
float depht = 2.79f;
float rating = 4.7f;
int reviews = 5413;
bool kindle = true;
bool flexibleCover = true;

// Stampa delle informazioni:

Console.WriteLine("-------IL LIBRO DI OGGI: " +  title + " di " + author + " -------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero delle pagine: " +  pages + " pagine");
Console.WriteLine("Peso del libro: " +  weight + "kg");
Console.WriteLine("Dimensioni del libro: " + lenght + "cm x " + height + "cm x " + depht + "cm");
Console.WriteLine(" ");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + reviews + " recensioni");
Console.WriteLine("Valutazione media: " + rating + " stelline");
Console.WriteLine("Kindle disponibile: " + kindle);
Console.WriteLine("Copertina flessibile disponibile: " + flexibleCover);
Console.WriteLine("---------------------------------------------------------------------------");