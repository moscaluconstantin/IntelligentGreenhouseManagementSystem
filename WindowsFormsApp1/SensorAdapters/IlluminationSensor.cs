using System;
using WindowsFormsApp1.Controllers;

namespace WindowsFormsApp1.Adapters
{
     class IlluminationSensor : ISensor
     {
          IlluminationController _IlluminationController;
          public IlluminationSensor()
          {
               _IlluminationController = new IlluminationController();
          }
          public double GetData()
          {
               var value = _IlluminationController.GetData();
               return Convert.ToDouble(value);
          }
     }
}
