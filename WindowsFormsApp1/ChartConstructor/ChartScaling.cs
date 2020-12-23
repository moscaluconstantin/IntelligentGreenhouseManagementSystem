using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ChartConstructor
{
     class ChartScaling
     {
          static public double[] FormatValues(double[] Values,int MaxNum)
          {
               double[] newValues = Values;
               while (newValues.Length > MaxNum)
               {
                    double[] temp = new double[newValues.Length / 2];
                    for (int i = 0; i < temp.Length; i++)
                    {
                         temp[i] = (newValues[i * 2] + newValues[i * 2 + 1]) / 2;
                    }
                    newValues = temp;
               }
               return newValues;
          }
          static public void PrintScale(Graphics G, RectangleF Borders, double YStep, double MinVal)
          {
               int ScaleStep = (int)(Borders.Bottom - 10) / 10;
               for (int i = 0; i < 10; i++)
               {
                    Point p = new Point(0, i * ScaleStep + 10);
                    int LineValue = (int)((Borders.Bottom - p.Y + 7) / YStep + MinVal);
                    G.DrawString(LineValue.ToString(), new Font(new FontFamily("Times New Roman"), 10), Brushes.Black, p);
                    G.DrawLine(Pens.Gray, 30, p.Y + 7, Borders.Right, p.Y + 7);
               }
               G.DrawLine(Pens.Black, 30, 0, 30, Borders.Bottom);
          }
     }
}
