using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class clients
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDclients { get; set; }
    [Required]
    public string firstname { get; set; }
    public string secondname { get; set; }
    public int phone { get; set; }
    public long IDcity { get; set; }
    [ForeignKey(name:"IDcity")]
    public City city { get; set; }
    public string address { get; set; } = null!;
    public string email { get; set; } = null!; 
}