using CSharpDiscovery.Quest04;
using System;

namespace TestCSharp
{
  public class HybridCar : Car, IThermalCar, IElectricCar
  {
    public HybridCar() {}

    public HybridCar(string model, string brand, string color, int currentSpeed = 0) : base(model, brand, color,
      currentSpeed) {}
    
    private int _FuelLevel = 100;
    private int _BatteryLevel = 100;
    
    public int FuelLevel
    {
      get { return _FuelLevel; }
      set { _FuelLevel = value;  }
    }
    public void FillUp()
    {
      FuelLevel = 100;
    }
    public int GetFuelLevel()
    {
      return FuelLevel;
    }

    public int BatteryLevel
    {
      get { return _BatteryLevel; }
      set { _BatteryLevel = value;  }
    }
    public void Recharge()
    {
      BatteryLevel = 100;
    }
    public int GetBatteryLevel()
    {
      return FuelLevel;
    }
    public override string ToString()
    {


        
      return $"{Color} {Brand} {Model}, Battery: {BatteryLevel}%, Fuel: {FuelLevel}%";
    }
    
    
    static void Main(string[] str)
    {
      var i8 = new HybridCar("i8", "BMW", "White");
      i8.BatteryLevel = 60;
      i8.FuelLevel = 80;
      Vehicule.WhoIsHere();

      i8.Recharge();
      i8.FillUp();
      Console.WriteLine(i8.GetBatteryLevel());
      Console.WriteLine(i8.GetFuelLevel());
    }
  }
}