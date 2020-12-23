using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFromsApp1.Database.Entities
{
     public class DataHistory
     {
          public int Id { get; set; }

          public int ZoneId { get; set; }
          public virtual Zone Zone { get; set; }
          public double SoilTemperature { get; set; }
          public double AirTemperature { get; set; }
          public double Humidity { get; set; }
          public double SoilMoisture { get; set; }
          public double CO2 { get; set; }
          public double Ph { get; set; }
          public double Illumintation { get; set; }
          public DateTime RegistrationDate { get; set; }
     }
}


