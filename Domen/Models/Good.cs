using System.ComponentModel.DataAnnotations;

namespace Domen.Models;

public class Good
{
    [Key]
    public int Ident { get; set; }
    [MaxLength(15)]
    public string Name { get; set; }
    public double Price { get; set; }
}