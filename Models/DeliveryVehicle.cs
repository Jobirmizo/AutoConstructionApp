﻿using System.ComponentModel.DataAnnotations;

namespace AutoConstructionApp.Models;

public class DeliveryVehicle
{
    [Key]
    public int Id { get; set; }
    public string Type { get; set; }
    public int Size { get; set; }
    public string Model { get; set; }
}