using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1.Controllers
{
     class IlluminationController
     {
          SerialPort serialPort;
          public IlluminationController()
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
