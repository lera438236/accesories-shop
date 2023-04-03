using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domen.Models;

public class addorder
{
    [Key]
    public int Ident { get; set; }
    public int ID_Orders { get; set; }
        public order order { get; set; }
    public int ID_Good { get; set; }
        public Good Good { get; set; }
    public int ID_client { get; set; }
        public clients clients { get; set; }
    public int Price { get; set; }
    public int amount { get; set; }
    public int sum { get; set; }
}