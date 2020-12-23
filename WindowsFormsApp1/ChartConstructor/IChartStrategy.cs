using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1.ChartConstructor
{
     interface IChartStrategy
     {
          void ViewChart(List<double> data, Graphics g);
     }
}
