using System.Data.Common;
using FilmER.Models;

internal class Program
{

    private static void Main(string[] args)
    {
        /*FilmDbContext dbc = new FilmDbContext();

        List<Film> elencoFilm = FilmController.GetFilms();
        List<Regista> elencoRegisti = FilmController.GetRegisti();

        dbc.Registi.AddRange(elencoRegisti);
        dbc.Films.AddRange(elencoFilm);
        dbc.SaveChanges();*/

        Console.WriteLine("inserisci l'anno di uscita dei film che vuoi trovare:");
        int anno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nFilm usciti nel " + anno + ": ");
        foreach (Film f in GetElencoFilmAnno(anno)) Console.WriteLine(f.ToString());
        Console.WriteLine("\nFilm prima del " + anno + ": ");
        foreach (Film f in GetElencoFilmPrimaAnno(anno)) Console.WriteLine(f.ToString());
        Console.WriteLine("\nFilm dopo il " + anno + ": ");
        foreach (Film f in GetElencoFilmDopoAnno(anno)) Console.WriteLine(f.ToString());

        Console.WriteLine("\n\nRegisti morti:");
        foreach (Regista r in GetElencoRegistiMorti()) Console.WriteLine(r.ToString());
        Console.WriteLine("\nRegisti vivi:");
        foreach (Regista r in GetElencoRegistiVivi()) Console.WriteLine(r.ToString());

    }
    private static List<Film> GetElencoFilmAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.Anno == anno)
                .ToList();
        return f;
    }
    public static bool FilmPresente(Film f)
    {
        FilmDbContext dbc = new FilmDbContext();
        bool p = dbc.Films
                .Contains(f);
        return p;
    }
    public static List<Film> GetElencoFilmDopoAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.Anno > anno)
                .ToList();
        return f;
    }
    public static List<Film> GetElencoFilmPrimaAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.Anno < anno)
                .ToList();
        return f;
    }
    public static List<Film> GetElencoFilm()
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .ToList();
        return f;
    }
    public static List<Regista> GetElencoRegisti()
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiVivi()
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Morte == null)
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiMorti()
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Morte != null)
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiNatiAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Nascita.Year == anno)
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiNatiDopoAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Nascita.Year > anno)
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiNatiPrimaAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Nascita.Year < anno)
                .ToList();
        return r;
    }
    public static Regista GetRegistaID(int id)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Id == id)
                .FirstOrDefault();
        return r;
    }
    public static Film GetFilmsID(int id)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.Id == id)
                .FirstOrDefault();
        return f;
    }
    public static List<Regista> GetElencoRegistiNazionalita(string nazionalita)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Nazionalita == nazionalita)
                .ToList();
        return r;
    }
    public static List<Regista> GetElencoRegistiNome(string nome)
    {
        FilmDbContext dbc = new FilmDbContext();
        var r = dbc.Registi
                .Where(regista => regista.Nome == nome)
                .ToList();
        return r;
    }
    public static List<Film> GetElencoFilmTitolo(string titolo)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.Titolo == titolo)
                .ToList();
        return f;
    }
    public static List<Film> GetElencoFilmIDRegista(int idRegista)
    {
        FilmDbContext dbc = new FilmDbContext();
        var f = dbc.Films
                .Where(film => film.idRegista == idRegista)
                .ToList();
        return f;
    }
}