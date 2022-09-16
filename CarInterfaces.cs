using System;

namespace CSharpDiscovery.Quest04
{
  public interface IThermalCar
  {
    public int FuelLevel;

    public void FillUp();
    public int GetFuelLevel();

  }
  public interface IElectricCar
  {
    public int BatteryLevel;
    public void Recharge();
    public int GetBatteryLevel();
    
  }
}