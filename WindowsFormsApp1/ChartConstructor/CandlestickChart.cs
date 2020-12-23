using System.Collections.Generic;
using System.Drawing;
using System;

namespace WindowsFormsApp1.ChartConstructor
{
     class CandlestickChart : IChartStrategy
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

               vals = ChartScaling.FormatValues(vals, (int)(width / 7) * 4);

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
               SolidBrush Gbr = new SolidBrush(Color.Green);
               SolidBrush Rbr = new SolidBrush(Color.Red);

               for (int i = 0; i < vals.Length; i++)
               {
                    vals[i] -= MinVal;
               }

               for (int i = 3; i < vals.Length; i+=4)
               {
                    int LocalX = (int)((i - 3) * XStep) + 30;
                    double LocalMax = Math.Max(Math.Max(vals[i], vals[i - 1]), Math.Max(vals[i - 2], vals[i - 3]));
                    double LocalMin= Math.Min(Math.Min(vals[i], vals[i - 1]), Math.Min(vals[i - 2], vals[i - 3]));


                    Point RecSt = new Point(LocalX, (int)(height - vals[i - 3] * YStep));
                    Point RecEn = new Point(LocalX, (int)(height - vals[i] * YStep));
                    Point LineSt = new Point(LocalX + 2, (int)(height - LocalMax * YStep));
                    Point LineEn = new Point(LocalX + 2, (int)(height - LocalMin * YStep));
                    g.DrawLine(Pens.Black, LineSt, LineEn);
                    int Y = Math.Max(RecSt.Y, RecEn.Y);
                    int H = RecSt.Y - RecEn.Y;
                    if (H > 0)
                    {
                         g.FillRectangle(Gbr, RecSt.X, Y, 5, Math.Abs(H));
                    }
                    else
                    {
                         g.FillRectangle(Rbr, RecSt.X, Y, 5, Math.Abs(H));
                    }
                    
               }
          }
     }
}
