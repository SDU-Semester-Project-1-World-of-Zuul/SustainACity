﻿namespace SustainACity.Model;

public class Room
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public NPC? NPC { get; set; }
}