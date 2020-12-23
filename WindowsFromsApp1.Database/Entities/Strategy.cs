namespace WindowsFromsApp1.Database.Entities
{
     public class Strategy
     {
          public int Id { get; set; }
          public string StrategyName { get; set; }
          public double SoilTemperature { get; set; }
          public double AirTemperature { get; set; }
          public double Humidity { get; set; }
          public double SoilMoisture { get; set; }
          public double CO2 { get; set; }
          public double Ph { get; set; }
          public double Illumintation { get; set; }
     }


}


