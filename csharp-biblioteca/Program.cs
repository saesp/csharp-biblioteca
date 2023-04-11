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

//users
User user = new User();
User user2 = new User();
User user3 = new User();

user.Firstname = "Salvatore";
user.Lastname = "Espsosito";
user.Email = "sa@live.it";
user.Password = "1234";
user.Phone = "331";

user2.Firstname = "Thomas";
user2.Lastname = "Rossi";
user2.Email = "to@live.it";
user2.Password = "1234";
user2.Phone = "332";

user3.Firstname = "Giada";
user3.Lastname = "Bianchi";
user3.Email = "gi@live.it";
user3.Password = "2345";
user3.Phone = "334";



//REGISTRATION
Console.WriteLine("REGISTRATI");


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


User user4 = new User();
user3.Firstname = _firstName;
user3.Lastname = _lastName;
user3.Email = _email;
user3.Password = _password;
user3.Phone = _phone;



//user list
List<User> userList = new List<User>();
userList.Add(user);
userList.Add(user2);
userList.Add(user3);
userList.Add(user4);



//LOGIN
Console.WriteLine("ACCEDI");


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


    Console.WriteLine("DOCUMENTI DISPONIBILI");


    Console.WriteLine("Dvd");

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


    Console.WriteLine("Libri");

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




//Super Class Document
class Document
{
    //attributi (private) + getter e setter
    public string Code { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Sector { get; set; }
    public string Shelf { get; set; }
    public string Author { get; set; }


    //methods
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


//classi figlie di Document
class Book : Document
{
    public short PagesNumber { get; set; }

    public override void WriteDocument()
    {
        base.WriteDocument();
        Console.WriteLine($"Pages number {PagesNumber}");
    }
}

class Dvd : Document
{
    public int Duration { get; set; }

    public override void WriteDocument()
    {
        base.WriteDocument();
        Console.WriteLine($"Duration {Duration}");
    }
}


//Class User 
class User
{
    //attributi (private) + getter e setter
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }


    public virtual void WriteUser()
    {
        Console.WriteLine($"Firstname {Firstname}");
        Console.WriteLine($"Lastname {Lastname}");
        Console.WriteLine($"Email {Email}");
        Console.WriteLine($"Password {Password}");
        Console.WriteLine($"Phone {Phone}");
    }
}
class Library
{
    //attributi (private) + getter e setter
    public List<Document> Documents;
    //public List<Users> Users;

}