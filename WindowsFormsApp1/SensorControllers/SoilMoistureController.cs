using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1.Controllers
{
     class SoilMoistureController
     {
          SerialPort serialPort;
          public SoilMoistureController()
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
