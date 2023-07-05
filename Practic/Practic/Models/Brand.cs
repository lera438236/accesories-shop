using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class brands
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDbrands { get; set; }
    [Required]
    public string name { get; set; }
    public List<products> Products { get; set; }
}