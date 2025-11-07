using FilmER.Models;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        FilmDbContext dbc = new FilmDbContext();

        List<Film> elencoFilm = FilmController.GetFilms();
        List<Regista> elencoRegisti = FilmController.GetRegisti();

        dbc.Registi.AddRange(elencoRegisti);
        dbc.Films.AddRange(elencoFilm);

        dbc.SaveChanges();
    }

    private static List<Film> GetElencoFilm()
    {
        FilmDbContext dbc = new FilmDbContext();

        var elenco = dbc.Films.ToList();

        return elenco;
    }

    private static List<Regista> GetElencoRegisti()
    {
        FilmDbContext dbc = new FilmDbContext();

        var elenco = dbc.Registi.ToList();

        return elenco;
    }

    private static Film GetFilm(int id)
    {
        FilmDbContext dbc = new FilmDbContext();

        var f = dbc.Films
            .Where(film => film.Id == id)
            .FirstOrDefault();

        return f;
    }

    private static Regista GetRegista(int id)
    {
        FilmDbContext dbc = new FilmDbContext();

        var r = dbc.Registi
            .Where(regista => regista.Id == id)
            .FirstOrDefault();

        return r;
    }

    private static List<Film> GetElencoFilmAnno(int anno)
    {
        FilmDbContext dbc = new FilmDbContext();

        var elenco = dbc.Films
            .Where(film => film.Anno == anno)
            .ToList();

        return elenco;
    }

    private static List<Regista> GetElencoRegistaAnnoNascita(DateOnly data)
    {
        FilmDbContext dbc = new FilmDbContext();

        var elenco = dbc.Registi
            .Where(regista => regista.Nascita == data)
            .ToList();

        return elenco;
    }
}
