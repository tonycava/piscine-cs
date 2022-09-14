using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; } = 0;
        public double Longitude { get; set; } = 0;
        public string Name { get; set; } = "";

        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Latitude = 44.854186;
            Longitude = -0.5663056;
            Name = "Bordeaux Ynov Campus";
        }

        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string GetGoogleMapsUrl()
        {
            return ($"https://www.google.com/maps/place/{Name.Replace(" ","+")}/@{Latitude},{Longitude},15z/");
        }

        public string ToString()
        {
            return ($"{Name} (Lat={Latitude}, Long={Longitude})");
        }
        
        public int GetDistance(PointOfInterest other)
        {
            double R = 6371;
            double dLat = other.Latitude * Math.PI / 180;
            double dLon = Latitude * Math.PI / 180;
            
            double allLat = (Latitude - other.Latitude) * Math.PI / 180;
            double allLong = (Longitude - other.Longitude) * Math.PI / 180;

            double a = Math.Sin(allLat / 2) * Math.Sin(allLat / 2) +
                       Math.Cos(dLat) * Math.Cos(dLon) * Math.Sin(allLong / 2) * Math.Sin(allLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;

            return (int)d + 1;
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            double R = 6371;
            double dLat = p1.Latitude * Math.PI / 180;
            double dLon = p2.Latitude * Math.PI / 180;
            
            double allLat = (p2.Latitude - p1.Latitude) * Math.PI / 180;
            double allLong = (p2.Longitude - p1.Longitude) * Math.PI / 180;

            double a = Math.Sin(allLat / 2) * Math.Sin(allLat / 2) +
                       Math.Cos(dLat) * Math.Cos(dLon) * Math.Sin(allLong / 2) * Math.Sin(allLong / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = R * c;

            return (int)d + 1;
        }
        
        
        static void Main(string[] str)
        {
            var BordeauxCampus = new PointOfInterest();
            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);

            Console.WriteLine(BordeauxCampus.GetDistance(ParisCampus));
            Console.WriteLine(PointOfInterest.GetDistance(BordeauxCampus, ParisCampus));
        }
    }
}