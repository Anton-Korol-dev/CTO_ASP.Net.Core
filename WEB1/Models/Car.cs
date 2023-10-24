using System.ComponentModel.DataAnnotations;

namespace WEB1.Models;

public class Car
{
    public string CarManufacturer { get; set; }

    public string CarModel { get; set; }

    public string YearOfManufactureOfTheCar { get; set; }

    public string FuelType { get; set; }

    public int ClientCode { get; set; }

    [Key] public string VinNumber { get; set; } = null!;

    public virtual List<Clients> ClientCodeNavigation { get; set; }
}
