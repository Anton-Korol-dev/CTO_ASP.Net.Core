using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WEB1.Models;

namespace WEB1.Models;

public class Clients
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    [Key] public string PhoneNumber { get; set; }
}
