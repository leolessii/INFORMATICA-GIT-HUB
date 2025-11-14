using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
public class Film
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string? Titolo { get; set; }
    public int idRegista { get; set; }
    public int Anno { get; set; }
    public Regista Regista { get; set; } = null!;
}