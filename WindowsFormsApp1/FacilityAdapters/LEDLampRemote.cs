using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class LEDLampRemote : IFacilities
     {
          LEDLampController _LEDLampController;
          public LEDLampRemote()
          {
               _LEDLampController = new LEDLampController();
          }
          public void Connect()
          {

          }
          public void TurnOn()
          {
               _LEDLampController.TurnOn();
          }
          public void TurnOff()
          {
               _LEDLampController.TurnOff();
          }
     }
}
