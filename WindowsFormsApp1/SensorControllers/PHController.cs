using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1.Controllers
{
     class PHController
     {
          SerialPort serialPort;
          public PHController()
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
