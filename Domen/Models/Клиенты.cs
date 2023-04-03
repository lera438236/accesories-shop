using System.ComponentModel.DataAnnotations;

namespace Domen.Models;

public class clients
{
    [Key]
    public int ID_client { get; set; }
    public string fistname { get; set; }
    public string lastname { get; set; }
    public string middlename { get; set; }
    public int phone  { get; set; }
}