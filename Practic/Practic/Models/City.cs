using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class City
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDcity { get; set; }
    [Required]
    public string name { get; set; } 
}