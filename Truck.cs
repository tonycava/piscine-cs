using System;

namespace CSharpDiscovery.Quest04
{

  public class Truck : Vehicule
  {

    public int Tonnage { get; set; } = 0;

    public Truck()
    {
      Tonnage = 0;
    }    
    
    public Truck(int tonnage, string brand, string color, int currentSpeed = 0)
    {
      Tonnage = tonnage;
      Brand = brand;
      Color = color;
      CurrentSpeed = currentSpeed;
    }


    public override string ToString()
    {
      return $"{Color} {Brand} {Tonnage}T Truck";
    }
    
    
    public override void Accelerate(int newSpeed)
    {
      if (CurrentSpeed + newSpeed > 100) CurrentSpeed = 180;
      else CurrentSpeed += newSpeed;
    }    
    
    public override void Brake(int newSpeed)
    {
      if (CurrentSpeed - newSpeed < 0) CurrentSpeed = 0;
      else CurrentSpeed -= newSpeed;
    }
  }
  
  
  class Program
  {
    static void Main(string[] str)
    {
      var RandomTruck = new Truck();
      var MAC = new Truck(2, "MAC", "White", 80);
      var Renault = new Truck(3, "Renault", "Black", 20);

      Vehicule.WhoIsHere();

      RandomTruck.Accelerate(30);
      MAC.Accelerate(40);
      Renault.Brake(30);

      Vehicule.WhoIsHere();
    }
  }
}