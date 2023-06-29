namespace Zadaniee1_Programowanie2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Karolina Nowak");
            Osoba osoba2 = new Osoba("Paulina Nowak");
            osoba.DataUrodzenia = new DateTime(1993, 11, 1);
            osoba.DataŚmierci = new DateTime(2000, 12, 31);


            Console.WriteLine(osoba.Imię);
            Console.WriteLine(osoba.Nazwisko);
            Console.WriteLine(osoba.DataUrodzenia?.ToString("yyyy-MM-dd"));
            Console.WriteLine(osoba.DataŚmierci?.ToString("yyyy-MM-dd"));
            Console.WriteLine(osoba.Wiek?.TotalDays);
            Console.WriteLine(osoba.ImięNazwisko);
        }
    }

}
