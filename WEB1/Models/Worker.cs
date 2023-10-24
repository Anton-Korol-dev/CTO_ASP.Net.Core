using System.ComponentModel.DataAnnotations;

namespace WEB1.Models;

public class Worker
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }
    public string Worker_Phone_Number { get; set; }
    public string Type_of_Worker { get; set; }
    public string Adress { get; set; }
    public string Experience { get; set; }
    [Key] public int ID { get; set; }
    public List<CTO> CTO_ID { get; set; }
}
