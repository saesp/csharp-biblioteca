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


if (emailLogin == _email && passwordLogin == _password)
    Console.WriteLine("Dati corretti");
else
    Console.WriteLine("Dati errati");



////array
//List<User> users = new List<User>(); 

//class User{
//    string firstName;
//    string lastName;
//    string email;
//    string password;
//    string phone;

//    public User(string firstName, string lastName, string email, string password, string phone)
//    {
//        this.firstName = firstName;
//        this.lastName = lastName;
//        this.email = email;
//        this.password = password; 
//        this.phone = phone;
//    }
//}



namespace library
{
    //superclasse
    public class Documents
    {
        //attributi (private) + getter e setter
        public string Code { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Sector { get; set; }
        public string Shelf { get; set; }
        public string Author { get; set; }
    }

    //classi figlie di Documents
    class Books : Documents
    {
        public short PagesNumber { get; set; }
    }

    class Dvd : Documents
    {
        public int Duration { get; set; }
    }
}





