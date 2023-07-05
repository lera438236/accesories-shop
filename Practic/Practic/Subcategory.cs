using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practic.Models;

public class subcategory
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IDsubcat { get; set; }
    public string name { get; set; }
}