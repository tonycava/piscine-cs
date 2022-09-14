namespace CSharpDiscovery.Quest03
{
  public class Campus : PointOfInterest
  {
    public int Capacity { get; set; } = 0;
    
    public string ToString()
    {
      return $"{Name} is a campus with a capacity of {Capacity} students";
    }
  }
}
