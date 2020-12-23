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

namespace WindowsFormsApp1
{
     public partial class Form1 : Form
     {
          Thread th;
          public Form1()
          {
               InitializeComponent();
               facilitiesControl.Visible = false;
               
          }

          private void Label5_Click(object sender, EventArgs e)
          {

          }

          private void Label8_Click(object sender, EventArgs e)
          {

          }

          private void Label10_Click(object sender, EventArgs e)
          {

          }

          private void Button1_Click(object sender, EventArgs e)
          {

          }

          private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void RadioButton2_CheckedChanged(object sender, EventArgs e)
          {
               facilitiesControl.Visible = true;
          }

          private void RadioButton1_CheckedChanged(object sender, EventArgs e)
          {

               facilitiesControl.Visible = false;
          }

          private void CreateNewGraphicToolStripMenuItem_Click(object sender, EventArgs e)
          {
               
               this.Close();
               th = new Thread(OpenNewForm);
               th.SetApartmentState(ApartmentState.STA);
               th.Start();
               
          }

          private void OpenNewForm(object obj)
          {
               Application.Run(new Form2());
          }
     }
}
