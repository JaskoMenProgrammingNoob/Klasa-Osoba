class Osoba
{
    string imie;
    string nazwisko;
    string ulica;
    string kod;
    string miasto;
    public void wczytaj()
    {
        Console.WriteLine("Podaj Imię: ");
        imie = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko: ");
        nazwisko = Console.ReadLine();
        Console.WriteLine("Podaj Ulicę: ");
        ulica = Console.ReadLine();
        Console.WriteLine("Podaj kod pocztowy: ");  
        kod = Console.ReadLine();
        Console.WriteLine("Podaj miasto: ");    
        miasto = Console.ReadLine();
        Console.WriteLine("================================");  
    }
   
    
    /// </summary>
    public void wyswietl()
    {
        Console.WriteLine("Imię: " + imie);
        Console.WriteLine("Nazwisko: " + nazwisko); 
        Console.WriteLine("Ulica: " + ulica);
        Console.WriteLine("Kod pocztowy: " + kod);
        Console.WriteLine("Miasto: " + miasto);



    }

    static void Main(string[] args)
    {
        Osoba osoba = new Osoba();
        osoba.wczytaj();

        osoba.wyswietl();



    }
}