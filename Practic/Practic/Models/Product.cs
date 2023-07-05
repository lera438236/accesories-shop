using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class products
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDprod { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public long IDcat { get; set; }
    [ForeignKey(name:"IDcat")]
    public category category { get; set; }
    public long IDsubcat { get; set; }
    [ForeignKey(name:"IDsubcat")]
    public subcategory subcategory { get; set; }
    public long IDbrands { get; set; }
    [ForeignKey(name:"IDbrands")]
    public brands brands { get; set; }
    public long IDcomm { get; set; }
    [ForeignKey(name:"IDcomm")]
    public comments comments { get; set; } 
}