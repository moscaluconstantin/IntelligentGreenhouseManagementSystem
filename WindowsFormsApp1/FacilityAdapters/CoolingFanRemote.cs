using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class CoolingFanRemote : IFacilities
     {
          CoolingFanController _CoolingFanController;
          public CoolingFanRemote()
          {
               _CoolingFanController = new CoolingFanController();
          }
          public void Connect()
          {

          }
          public void TurnOn()
          {
               _CoolingFanController.TurnOn();
          }
          public void TurnOff()
          {
               _CoolingFanController.TurnOff();
          }
     }
}
