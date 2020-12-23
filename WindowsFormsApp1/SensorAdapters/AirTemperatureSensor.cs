using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class AirTemperatureSensor : ISensor
     {
          AirTemperatureController _AirTemperatureController;
          public AirTemperatureSensor()
          {
               _AirTemperatureController = new AirTemperatureController();
          }
          public double GetData()
          {
               var value = _AirTemperatureController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
