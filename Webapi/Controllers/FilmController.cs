using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/film")]
public class FilmController: ControllerBase
{
    [HttpGet]
    public IActionResult GetFilms()
    {
        var films = new[]
        {
            new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
            new Film {Id=2, Titolo="Fast and Furious", idRegista= 1, Anno = 2001 },
            new Film {Id=3, Titolo="Jurassic Park", idRegista= 1, Anno = 1993 },
            new Film {Id=4, Titolo="Spooder-Man", idRegista= 1, Anno = 2007 },
            new Film {Id=5, Titolo="jew-jitsu", idRegista= 1, Anno = 2025 }
        };

        return Ok(films);
    }

    [HttpGet]
    public IActionResult GetFilms()
    {
        var films = new[]
        {
            new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
            new Film {Id=2, Titolo="Fast and Furious", idRegista= 1, Anno = 2001 },
            new Film {Id=3, Titolo="Jurassic Park", idRegista= 1, Anno = 1993 },
            new Film {Id=4, Titolo="Spooder-Man", idRegista= 1, Anno = 2007 },
            new Film {Id=5, Titolo="jew-jitsu", idRegista= 1, Anno = 2025 }
        };

        return Ok(films);
    }
}