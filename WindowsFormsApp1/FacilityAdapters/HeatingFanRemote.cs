using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class HeatingFanRemote : IFacilities
     {
          HeatingFanController _HeatingFanController;
          public HeatingFanRemote()
          {
               _HeatingFanController = new HeatingFanController();
          }
          public void Connect()
          {

          }
          public void TurnOn()
          {
               _HeatingFanController.TurnOn();
          }
          public void TurnOff()
          {
               _HeatingFanController.TurnOff();
          }
     }
}
