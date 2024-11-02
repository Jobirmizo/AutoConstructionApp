using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConstructionApp.Models;

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("ConstructionVehicle")]
    public int ConstructionId { get; set; }
    [ForeignKey("DeliveryVehicle")]
    public int DeliveryId { get; set; }
}