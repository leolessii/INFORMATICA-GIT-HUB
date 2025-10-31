using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

public class FilmController: ControllerBase
{
    public Film[] GetFilms()
    {
        Film[] films = new[]
        {
            new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
            new Film {Id=2, Titolo="Fast and Furious", idRegista= 1, Anno = 2001 },
            new Film {Id=3, Titolo="Jurassic Park", idRegista= 1, Anno = 1993 }
        };

        return films;
    }
}