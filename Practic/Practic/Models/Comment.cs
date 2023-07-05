using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class comments
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDcomm { get; set; }
    [Required]
    [MaxLength(150)]
    [Column(name: "Comments")]
    
    public string name { get; set; }
    public long IDproducts { get; set; }
    [ForeignKey(name:"IDprod")]
    public products Products { get; set; }  
}