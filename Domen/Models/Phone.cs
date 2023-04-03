using System.ComponentModel.DataAnnotations;

namespace Domen.Models;

public class Phone
{
    [Key]
    public int Ident { get; set; }
    public string Producer { get; set; }
    public string model  { get; set; }
}