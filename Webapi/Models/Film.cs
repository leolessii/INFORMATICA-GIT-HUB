public class Film
{
    public int Id { get; set; }
    public string? Titolo { get; set; }
    public int idRegista { get; set; }
    public int Anno { get; set; }
    public Regista Regista { get; set; } = null!;
}