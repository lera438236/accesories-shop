using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Domen.Models;

public class order
{
    [Key]
    public int Ident { get; set; }
    public DateTime Date { get; set; }
    public double sum { get; set; }
    public int? ID_client { get; set; }
        [ForeignKey("ID_client")]
            public clients clients { get; set; }
}