using System;

namespace CSharpDiscovery.Quest04
{
  public class Car : Vehicule 
  {
    public string Model { get; set; } = "";
    
    public Car()
    {
      Brand = "Unknown";
      Model = "Unknown";
      Color = "Unknown";
    }    
    
    public Car(string model, string brand, string color, int currentSpeed = 0)
    {
      Model = model;
      Brand = brand;
      Color = color;
      CurrentSpeed  = currentSpeed;
    }
    
    public override string ToString()
    {
      return $"{Color} {Brand} {Model}";
    }


    public override void Accelerate(int newSpeed)
    {
      if (CurrentSpeed + newSpeed > 180) CurrentSpeed = 180;
      else CurrentSpeed += newSpeed;
    }    
    
    public override void Brake(int newSpeed)
    {
      if (CurrentSpeed - newSpeed < 0) CurrentSpeed = 0;
      else CurrentSpeed -= newSpeed;
    }
    
    
  }
  
}