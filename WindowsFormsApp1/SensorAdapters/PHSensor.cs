using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class PHSensor : ISensor
     {
          PHController _PHController;
          public PHSensor()
          {
               _PHController = new PHController();
          }
          public double GetData()
          {
               var value = _PHController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
