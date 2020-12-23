using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class VentilationRemote : IFacilities
     {
          VentilationController _VentilationController;
          public VentilationRemote()
          {
               _VentilationController = new VentilationController();
          }
          public void Connect()
          {
               //...
          }
          public void TurnOn()
          {
               _VentilationController.TurnOn();
          }
          public void TurnOff()
          {
               _VentilationController.TurnOff();
          }
     }
}
