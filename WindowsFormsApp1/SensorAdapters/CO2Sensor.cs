using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class CO2Sensor : ISensor
     {
          CO2Controller _CO2Controller;
          public CO2Sensor()
          {
               _CO2Controller = new CO2Controller();
          }
          public double GetData()
          {
               var value = _CO2Controller.GetData();
               return Convert.ToDouble(value);
          }
     }
}
