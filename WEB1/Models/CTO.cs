using System.ComponentModel.DataAnnotations;
using WEB1.Models;

namespace WEB1.Models;

public class CTO
{
    [Key] public int Id { get; set; }
    public string Name_of_CTO { get; set; }
    public string Amount_of_workers { get; set; }
}
