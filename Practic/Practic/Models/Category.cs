using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class category
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDcat { get; set; }
    [Required]
    [MaxLength(150)]
    public string name { get; set; }
}