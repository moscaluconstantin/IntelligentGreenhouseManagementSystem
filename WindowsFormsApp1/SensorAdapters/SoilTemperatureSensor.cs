using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class SoilTemperatureSensor : ISensor
     {
          SoilTemperatureController _SoilTemperatureController;
          public SoilTemperatureSensor()
          {
               _SoilTemperatureController = new SoilTemperatureController();
          }
          public double GetData()
          {
               var value = _SoilTemperatureController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
