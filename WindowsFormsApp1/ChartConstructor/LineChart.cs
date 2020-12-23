using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1.ChartConstructor
{
     class LineChart : IChartStrategy
     {
          public void ViewChart(List<double> data, Graphics g)
          {
               RectangleF r = g.VisibleClipBounds;
               float width = r.Right - r.Left;
               float height = r.Bottom - r.Top;
               int num = data.Count;

               //double[] vals = data.ToArray();

               double[] vals = new double[10000];
               Random rad = new Random();
               for (int i = 0; i < vals.Length; i++)
               {
                    vals[i] = rad.Next(-20, 50);
               }

               vals = ChartScaling.FormatValues(vals, (int)width / 3);

               double XStep = width / vals.Length;
               double YStep;

               double MaxVal = vals[0];
               double MinVal = vals[0];

               foreach(double x in vals)
               {
                    if (x > MaxVal)
                    {
                         MaxVal = x;
                    }
                    if (x < MinVal)
                    {
                         MinVal = x;
                    }
               }
               YStep = height / (MaxVal - MinVal);

               ChartScaling.PrintScale(g, r, YStep, MinVal);

               for (int i = 0; i < vals.Length; i++)
               {
                    vals[i] -= MinVal;
                    if (i > 0)
                    {
                         Point St = new Point((int)((i - 1) * XStep) + 30, (int)(height - vals[i - 1] * YStep));
                         Point En = new Point((int)((i) * XStep) + 30, (int)(height - vals[i]*YStep));
                         g.DrawLine(Pens.Black, St,En);
                    }
               }
          }
     }
}
