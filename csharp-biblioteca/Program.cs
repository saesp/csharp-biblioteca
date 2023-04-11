//Si vuole progettare un sistema per la gestione di una biblioteca.

//Gli utenti si possono registrare al sistema, fornendo:
//nome
//cognome
//email
//password
//recapito telefonico

//Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).

//I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa
//titolo
//anno
//settore (storia, matematica, economia, …)
//uno scaffale in cui è posizionato
//un autore (Nome, Cognome)

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti. Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.


//USERS

//registration
using System.ComponentModel;

Console.WriteLine("Registrati");


Console.WriteLine("Nome:");
string _firstName = Console.ReadLine();

Console.WriteLine("Cognome:");
string _lastName = Console.ReadLine();

Console.WriteLine("Email:");
string _email = Console.ReadLine();

Console.WriteLine("Password:");
string _password = Console.ReadLine();

Console.WriteLine("Numero cellulare:");
string _phone = Console.ReadLine();


//add in array
List<string> userFirstname = new List<string> ();
userFirstname.Add(_firstName);

List<string> userLastname = new List<string>();
userLastname.Add(_lastName);

List<string> emailUser = new List<string>();
emailUser.Add(_email);

List<string> passwordUser = new List<string>();
passwordUser.Add(_password);

List<string> phoneUser = new List<string>();
phoneUser.Add(_phone);



//login
Console.WriteLine("Accedi");


Console.WriteLine("Tua email:");
string emailLogin = Console.ReadLine();

Console.WriteLine("Tua password:");
string passwordLogin = Console.ReadLine();


if (emailLogin != _email && passwordLogin != _password)
{
    Console.WriteLine("Dati errati");
}
else
{
    Console.WriteLine("Dati corretti");
    Dvd dvd = new Dvd();
    dvd.Code = "1";
    dvd.Title = "title dvd 1";
    dvd.Year = "2020";
    dvd.Sector = "history";
    dvd.Shelf = "A2";
    dvd.Author = "R.M.";
    dvd.Duration = 120;
    dvd.WriteDocument();

    Dvd dvd2 = new Dvd();
    dvd2.Code = "14";
    dvd2.Title = "title dvd 2";
    dvd2.Year = "2000";
    dvd2.Sector = "history";
    dvd2.Shelf = "F3";
    dvd2.Author = "W.A.";
    dvd2.Duration = 60;
    dvd2.WriteDocument();

    Book book = new Book();
    book.Code = "4";
    book.Title = "title book 1";
    book.Year = "2010";
    book.Sector = "psychology";
    book.Shelf = "B1";
    book.Author = "E.J.";
    book.PagesNumber = 1000;
    book.WriteDocument();

    Book book2 = new Book();
    book2.Code = "8";
    book2.Title = "title book 2";
    book2.Year = "2015";
    book2.Sector = "horror";
    book2.Shelf = "B5";
    book2.Author = "U.L.";
    book2.PagesNumber = 500;
    book2.WriteDocument();
}





//superclasse
class Document
{
    //attributi (private) + getter e setter
    public string Code { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Sector { get; set; }
    public string Shelf { get; set; }
    public string Author { get; set; }


    public virtual void WriteDocument()
    {
        Console.WriteLine($"Code {Code}");
        Console.WriteLine($"Title {Title}");
        Console.WriteLine($"Year {Year}");
        Console.WriteLine($"Sector {Sector}");
        Console.WriteLine($"Shelf {Shelf}");
        Console.WriteLine($"Author {Author}");
    }
}


//classi figlie di Documents
class Book : Documents
{
    public short PagesNumber { get; set; }

    public override void WriteDocument()
    {
        base.WriteDocument();
        Console.WriteLine($"Pages number {PagesNumber}");
    }
}

class Dvd : Documents
{
    public int Duration { get; set; }

    public override void WriteDocument()
    {
        base.WriteDocument();
        Console.WriteLine($"Duration {Duration}");
    }
}

//users 
class Document
{
    //attributi (private) + getter e setter
    public string Code { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Sector { get; set; }
    public string Shelf { get; set; }
    public string Author { get; set; }


    public virtual void WriteDocument()
    {
        Console.WriteLine($"Code {Code}");
        Console.WriteLine($"Title {Title}");
        Console.WriteLine($"Year {Year}");
        Console.WriteLine($"Sector {Sector}");
        Console.WriteLine($"Shelf {Shelf}");
        Console.WriteLine($"Author {Author}");
    }
}
class Library
{
    //attributi (private) + getter e setter
    public List<Documents> Documents;
    //public List<Users> Users;

}