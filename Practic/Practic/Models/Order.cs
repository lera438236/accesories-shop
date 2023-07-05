using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class order
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDorders { get; set; }
    [Required]
    public DateTime Date { get; set; }
    public DeliveryMode DeliveryMode { get; set; }
    public string price;
    public string amount;
    public string sum;
    public long IDclients { get; set; }
    [ForeignKey(name:"IDclients")]
    public clients clients { get; set; }
    public string comment;
}