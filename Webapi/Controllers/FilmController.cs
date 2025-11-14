using System.Data.Common;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/film")]
public class FilmController: ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Film>>> GetFilms()
    {
        FilmDbContext dbc = new FilmDbContext();

        var elenco = await dbc.Film.ToListAsync();
        return Ok(elenco);
    }
    // public IActionResult GetFilms()
    // {
    //     var films = new[]
    //     {
    //         new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
    //         new Film {Id=2, Titolo="Fast and Furious", idRegista= 1, Anno = 2001 },
    //         new Film {Id=3, Titolo="Jurassic Park", idRegista= 1, Anno = 1993 },
    //         new Film {Id=4, Titolo="Spooder-Man", idRegista= 1, Anno = 2007 },
    //         new Film {Id=5, Titolo="jew-jitsu", idRegista= 1, Anno = 2025 }
    //     };

    //     return Ok(films);
    // }

    [HttpGet("{id:int}")]
    public IActionResult GetSingleFilm(int id)
    {
        var films = new[]
        {
            new Film {Id=1, Titolo="Ready Player One", idRegista= 1, Anno = 2018 },
            new Film {Id=2, Titolo="Fuasto e Furioso", idRegista= 1, Anno = 2001 },
            new Film {Id=3, Titolo="Jurassic Pork", idRegista= 1, Anno = 1993 },
            new Film {Id=4, Titolo="Spooder-Man", idRegista= 1, Anno = 2007 },
            new Film {Id=5, Titolo="jew-jitsu", idRegista= 1, Anno = 2025 },
            new Film {Id=6, Titolo="The Greatest Sorcerer Of The History VS The Gratest Sorcerer of Modern Time", idRegista= 1, Anno=2025 }
        };

        Film film = films.FirstOrDefault( f => f.Id == id);
        if(film != null)
            return Ok(film);
        else return NotFound();
    }
}