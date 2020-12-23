using System.Collections.Generic;
using System.Drawing;
using System;

namespace WindowsFormsApp1.ChartConstructor
{
     class BarChart : IChartStrategy
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

               vals = ChartScaling.FormatValues(vals, (int)width / 7);

               double XStep = width / vals.Length;
               double YStep;

               double MaxVal = vals[0];
               double MinVal = vals[0];

               foreach (double x in vals)
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
               SolidBrush br = new SolidBrush(Color.Blue);

               for (int i = 0; i < vals.Length; i++)
               {
                    vals[i] -= MinVal;

                    Point St = new Point((int)((i) * XStep) + 30, (int)(height - vals[i] * YStep));
                    Point En = new Point((int)((i) * XStep) + 35, (int)r.Bottom);
                    g.FillRectangle(br, new Rectangle(St, new Size(En.X - St.X, En.Y - St.Y)));
               }
          }
     }
}
