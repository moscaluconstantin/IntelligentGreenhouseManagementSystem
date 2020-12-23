using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1.Controllers
{
     class HumidityController
     {
          SerialPort serialPort;
          public HumidityController()
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
