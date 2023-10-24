using System.ComponentModel.DataAnnotations;

namespace WEB1.Models;

public class Ordering
{
    public string VIN_Number { get; set; }
    public List<Clients> Client_Phone_Number { get; set; }
    public string Manager { get; set; }
    [Key] public int ID { get; set; }
}
