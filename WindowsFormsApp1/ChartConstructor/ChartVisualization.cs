using ProiectDeAn.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFromsApp1.Database.Entities;

namespace WindowsFormsApp1.ChartConstructor
{
     class ChartVisualization
     {
          IChartStrategy _ChartStrategy;
          public void SetChartStrategy(IChartStrategy chartStrategy)
          {
               _ChartStrategy = chartStrategy;
          }
          public void ViewChart(List<double> data, Graphics g)
          {
               _ChartStrategy.ViewChart(data, g);
          }
     }
}
