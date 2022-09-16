﻿using System;

namespace CSharpDiscovery.Quest04
{
  public class Car : Vehicule 
  {
    public string Model { get; set; } = "";
    public string Brand { get; set; } = "";
    public string Color { get; set; } = "";
    public int CurrentSpeed { get; set; } = 0;

    public Car()
    {
      Brand = "Unknown";
      Model = "Unknown";
      Color = "Unknown";
    }    
    
    public Car(string model, string brand, string color, int speed = 0)
    {
      Model = model;
      Brand = brand;
      Color = color;
      base.CurrentSpeed  = speed;
    }
    
    public override string ToString()
    {
      return $"{Color} {Brand} {Model}";
    }
    
    
    static void Main(string[] str)
    {
      var RandomCar = new Car();
      var Megane = new Car("Mégane", "Renault", "Yellow", 50);
      Vehicule.WhoIsHere();
    }
  }
  
}