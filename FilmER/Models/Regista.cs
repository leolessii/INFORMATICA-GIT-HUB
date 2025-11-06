using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
public class Regista
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public DateOnly Nascita { get; set; }
    public DateOnly? Morte { get; set; }
    public string? Nazionalita { get; set; }
    public ICollection<Film> Films { get; set; } = new List<Film>();
}