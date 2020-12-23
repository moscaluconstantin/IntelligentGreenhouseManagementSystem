using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class SoilMoistureSensor : ISensor
     {
          SoilMoistureController _SoilMoistureController;
          public SoilMoistureSensor()
          {
               _SoilMoistureController = new SoilMoistureController();
          }
          public double GetData()
          {
               var value = _SoilMoistureController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
