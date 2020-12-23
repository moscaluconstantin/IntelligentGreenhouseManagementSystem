using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProiectDeAn.Database;
using WindowsFormsApp1.ChartConstructor;

namespace WindowsFormsApp1
{
     public partial class Form2 : Form
     {
          Thread th;
          Graphics Gr;
          enum Columns{ AirTemp, CO2, Humid, Illumin, PH, SoilMois, SoilTemp }
          enum Charts { LineChart, BarChart, CandlestickChart }
          public Form2()
          {
               InitializeComponent();
               Gr = ChartPanel.CreateGraphics();
               AirTempRadioButton.Checked = true;
               LCRadioButton.Checked = true;
          }

          private void Button1_Click(object sender, EventArgs e)
          {
               this.Close();
               th = new Thread(OpenNewForm);
               th.SetApartmentState(ApartmentState.STA);
               th.Start();
          }

          private void OpenNewForm(object obj)
          {
               Application.Run(new Form1());
          }

          private void ConsructButton_Click(object sender, EventArgs e)
          {
               Gr.Clear(SystemColors.Control);
               DatabaseContext databaseContext = DatabaseContext.GetInstance();
               List<double> data = new List<double>();
               ChartVisualization chart = new ChartVisualization();
               //if (AirTempRadioButton.Checked)
               //{

               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.AirTemperature).ToList<double>();
               //}
               //else if (CO2RadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.CO2).ToList<double>();
               //}else if (HumidityRadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.Humidity).ToList<double>();
               //}else if (IlluminationRadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.Illumintation).ToList<double>();
               //}else if (PHRadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.Ph).ToList<double>();
               //}else if (SoilMoistRadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate < ToDateTimePicker.Value
               //             select col.SoilMoisture).ToList<double>();
               //}else if (SoilTempRadioButton.Checked)
               //{
               //     data = (from col in databaseContext.DataHistories
               //             where col.RegistrationDate > FromDateTimePicker.Value &&
               //             col.RegistrationDate<ToDateTimePicker.Value
               //             select col.SoilMoisture).ToList<double>();
               //}

               if (LCRadioButton.Checked)
               {
                    chart.SetChartStrategy(new LineChart());
               }else if (BCRadioButton.Checked)
               {
                    chart.SetChartStrategy(new BarChart());
               }else if (CsCRadioButton.Checked)
               {
                    chart.SetChartStrategy(new CandlestickChart());
               }
               chart.ViewChart(data, Gr);
          }
     }
}
