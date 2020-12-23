using ProiectDeAn.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class TestClass
     {

          DatabaseContext databaseContext =  DatabaseContext.GetInstance(); // created database context
          public void TEST()
          {
               databaseContext.DataHistories.Where(x => x.CO2 == 10).Select(x => x.AirTemperature);
               var b = databaseContext.Zones.Join(databaseContext.Strategies, x => x.StrategyId, y => y.Id,
                    (x, y) => new { x }).ToList();
          }
     }
}
