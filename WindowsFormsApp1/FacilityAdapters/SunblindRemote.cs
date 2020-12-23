using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class SunblindRemote : IFacilities
     {
          SunblindController _SunblindController;
          public SunblindRemote()
          {
               _SunblindController = new SunblindController();
          }
          public void Connect()
          {

          }
          public void TurnOn()
          {
               _SunblindController.TurnOn();
          }
          public void TurnOff()
          {
               _SunblindController.TurnOff();
          }
     }
}
