using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class HumiditySensor : ISensor
     {
          HumidityController _HumidityController;
          public HumiditySensor()
          {
               _HumidityController = new HumidityController();
          }
          public double GetData()
          {
               var value = _HumidityController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
