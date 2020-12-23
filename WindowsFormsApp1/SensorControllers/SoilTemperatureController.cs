using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1.Controllers
{
     class SoilTemperatureController
     {
          SerialPort serialPort;
          public SoilTemperatureController()
          {
               serialPort = new SerialPort();
               //...
          }
          public string GetData()
          {
               return serialPort.ReadLine();
          }
     }
}
