public class Regista
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public DateOnly Nascita { get; set; }
    public DateOnly? Morte { get; set; }
    public string? Nazionalita { get; set; }
}