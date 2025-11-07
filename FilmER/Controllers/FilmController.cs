using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

public class FilmController: ControllerBase
{
    public static List<Film> GetFilms()
    {
        var films = new[]
        {
            new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
            new Film {Id=2, Titolo="Fast and Furious", idRegista= 1, Anno = 2001 },
            new Film {Id=3, Titolo="Jurassic Park", idRegista= 1, Anno = 1993 },
            new Film {Id=4, Titolo="Spooder-Man", idRegista= 1, Anno = 2007 },
            new Film {Id=5, Titolo="jew-jitsu", idRegista= 1, Anno = 2025 }
        };

        return films.ToList();
    }

    public static List<Regista> GetRegisti()
    {
        var Registi = new[]
        {
            new Regista {Id=1, Nome="A1", Nascita=new DateOnly(2000,1,1), Morte=null, Nazionalita="IT"},
            new Regista {Id=2, Nome="A2", Nascita=new DateOnly(2000,1,2), Morte=null, Nazionalita="UK"},
            new Regista {Id=3, Nome="A3", Nascita=new DateOnly(2000,1,3), Morte=null, Nazionalita="FR"}
        };

        return Registi.ToList();
    }
}