using FilmER.Models;

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
}
