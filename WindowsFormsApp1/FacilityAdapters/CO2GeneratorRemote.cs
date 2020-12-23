using WindowsFormsApp1.FacilityControllers;

namespace WindowsFormsApp1.FacilityAdapters
{
     class CO2GeneratorRemote : IFacilities
     {
          CO2GeneratorController _GetO2GeneratorController;
          public CO2GeneratorRemote()
          {
               _GetO2GeneratorController = new CO2GeneratorController();
          }
          public void Connect()
          {

          }
          public void TurnOn()
          {
               _GetO2GeneratorController.TurnOn();
          }
          public void TurnOff()
          {
               _GetO2GeneratorController.TurnOff();
          }
     }
}
