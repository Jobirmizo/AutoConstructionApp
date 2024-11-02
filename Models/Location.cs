using System.ComponentModel.DataAnnotations;

namespace AutoConstructionApp.Models;

public class Location
{
    [Key]
    public int Id { get; set; }
    public string PLace { get; set; }
    public string Coordinates { get; set; }
}