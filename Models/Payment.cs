using System.ComponentModel.DataAnnotations;

namespace AutoConstructionApp.Models;

public class Payment
{
    [Key]
    public int Id { get; set; }
    public string Type { get; set; }
    public string Currency { get; set; }
    public decimal Value { get; set; }
}