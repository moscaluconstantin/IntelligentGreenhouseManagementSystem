namespace WindowsFormsApp1
{
     partial class Form2
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.masterDataSet = new WindowsFormsApp1.masterDataSet();
               this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.AirTempRadioButton = new System.Windows.Forms.RadioButton();
               this.CO2RadioButton = new System.Windows.Forms.RadioButton();
               this.HumidityRadioButton = new System.Windows.Forms.RadioButton();
               this.IlluminationRadioButton = new System.Windows.Forms.RadioButton();
               this.PHRadioButton = new System.Windows.Forms.RadioButton();
               this.SoilMoistRadioButton = new System.Windows.Forms.RadioButton();
               this.SoilTempRadioButton = new System.Windows.Forms.RadioButton();
               this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
               this.DataSelection = new System.Windows.Forms.GroupBox();
               this.LCRadioButton = new System.Windows.Forms.RadioButton();
               this.BCRadioButton = new System.Windows.Forms.RadioButton();
               this.CsCRadioButton = new System.Windows.Forms.RadioButton();
               this.ChartTypeSelection = new System.Windows.Forms.GroupBox();
               this.ConsructButton = new System.Windows.Forms.Button();
               this.ChartPanel = new System.Windows.Forms.Panel();
               ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
               this.DataSelection.SuspendLayout();
               this.ChartTypeSelection.SuspendLayout();
               this.SuspendLayout();
               // 
               // masterDataSet
               // 
               this.masterDataSet.DataSetName = "masterDataSet";
               this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // masterDataSetBindingSource
               // 
               this.masterDataSetBindingSource.DataSource = this.masterDataSet;
               this.masterDataSetBindingSource.Position = 0;
               // 
               // AirTempRadioButton
               // 
               this.AirTempRadioButton.AutoSize = true;
               this.AirTempRadioButton.Location = new System.Drawing.Point(6, 19);
               this.AirTempRadioButton.Name = "AirTempRadioButton";
               this.AirTempRadioButton.Size = new System.Drawing.Size(100, 17);
               this.AirTempRadioButton.TabIndex = 2;
               this.AirTempRadioButton.TabStop = true;
               this.AirTempRadioButton.Text = "Air Temperature";
               this.AirTempRadioButton.UseVisualStyleBackColor = true;
               // 
               // CO2RadioButton
               // 
               this.CO2RadioButton.AutoSize = true;
               this.CO2RadioButton.Location = new System.Drawing.Point(6, 42);
               this.CO2RadioButton.Name = "CO2RadioButton";
               this.CO2RadioButton.Size = new System.Drawing.Size(46, 17);
               this.CO2RadioButton.TabIndex = 3;
               this.CO2RadioButton.TabStop = true;
               this.CO2RadioButton.Text = "CO2";
               this.CO2RadioButton.UseVisualStyleBackColor = true;
               // 
               // HumidityRadioButton
               // 
               this.HumidityRadioButton.AutoSize = true;
               this.HumidityRadioButton.Location = new System.Drawing.Point(6, 65);
               this.HumidityRadioButton.Name = "HumidityRadioButton";
               this.HumidityRadioButton.Size = new System.Drawing.Size(65, 17);
               this.HumidityRadioButton.TabIndex = 4;
               this.HumidityRadioButton.TabStop = true;
               this.HumidityRadioButton.Text = "Humidity";
               this.HumidityRadioButton.UseVisualStyleBackColor = true;
               // 
               // IlluminationRadioButton
               // 
               this.IlluminationRadioButton.AutoSize = true;
               this.IlluminationRadioButton.Location = new System.Drawing.Point(6, 88);
               this.IlluminationRadioButton.Name = "IlluminationRadioButton";
               this.IlluminationRadioButton.Size = new System.Drawing.Size(77, 17);
               this.IlluminationRadioButton.TabIndex = 5;
               this.IlluminationRadioButton.TabStop = true;
               this.IlluminationRadioButton.Text = "Illumination";
               this.IlluminationRadioButton.UseVisualStyleBackColor = true;
               // 
               // PHRadioButton
               // 
               this.PHRadioButton.AutoSize = true;
               this.PHRadioButton.Location = new System.Drawing.Point(6, 111);
               this.PHRadioButton.Name = "PHRadioButton";
               this.PHRadioButton.Size = new System.Drawing.Size(40, 17);
               this.PHRadioButton.TabIndex = 6;
               this.PHRadioButton.TabStop = true;
               this.PHRadioButton.Text = "PH";
               this.PHRadioButton.UseVisualStyleBackColor = true;
               // 
               // SoilMoistRadioButton
               // 
               this.SoilMoistRadioButton.AutoSize = true;
               this.SoilMoistRadioButton.Location = new System.Drawing.Point(7, 134);
               this.SoilMoistRadioButton.Name = "SoilMoistRadioButton";
               this.SoilMoistRadioButton.Size = new System.Drawing.Size(85, 17);
               this.SoilMoistRadioButton.TabIndex = 7;
               this.SoilMoistRadioButton.TabStop = true;
               this.SoilMoistRadioButton.Text = "Soil Moisture";
               this.SoilMoistRadioButton.UseVisualStyleBackColor = true;
               // 
               // SoilTempRadioButton
               // 
               this.SoilTempRadioButton.AutoSize = true;
               this.SoilTempRadioButton.Location = new System.Drawing.Point(7, 157);
               this.SoilTempRadioButton.Name = "SoilTempRadioButton";
               this.SoilTempRadioButton.Size = new System.Drawing.Size(105, 17);
               this.SoilTempRadioButton.TabIndex = 8;
               this.SoilTempRadioButton.TabStop = true;
               this.SoilTempRadioButton.Text = "Soil Temperature";
               this.SoilTempRadioButton.UseVisualStyleBackColor = true;
               // 
               // FromDateTimePicker
               // 
               this.FromDateTimePicker.Location = new System.Drawing.Point(12, 205);
               this.FromDateTimePicker.Name = "FromDateTimePicker";
               this.FromDateTimePicker.Size = new System.Drawing.Size(117, 20);
               this.FromDateTimePicker.TabIndex = 9;
               this.FromDateTimePicker.Value = new System.DateTime(2020, 5, 1, 9, 36, 0, 0);
               // 
               // ToDateTimePicker
               // 
               this.ToDateTimePicker.Location = new System.Drawing.Point(135, 205);
               this.ToDateTimePicker.Name = "ToDateTimePicker";
               this.ToDateTimePicker.Size = new System.Drawing.Size(117, 20);
               this.ToDateTimePicker.TabIndex = 10;
               // 
               // DataSelection
               // 
               this.DataSelection.Controls.Add(this.SoilMoistRadioButton);
               this.DataSelection.Controls.Add(this.PHRadioButton);
               this.DataSelection.Controls.Add(this.IlluminationRadioButton);
               this.DataSelection.Controls.Add(this.HumidityRadioButton);
               this.DataSelection.Controls.Add(this.CO2RadioButton);
               this.DataSelection.Controls.Add(this.AirTempRadioButton);
               this.DataSelection.Controls.Add(this.SoilTempRadioButton);
               this.DataSelection.Location = new System.Drawing.Point(12, 12);
               this.DataSelection.Name = "DataSelection";
               this.DataSelection.Size = new System.Drawing.Size(117, 187);
               this.DataSelection.TabIndex = 11;
               this.DataSelection.TabStop = false;
               this.DataSelection.Text = "Data Selection";
               // 
               // LCRadioButton
               // 
               this.LCRadioButton.AutoSize = true;
               this.LCRadioButton.Location = new System.Drawing.Point(6, 18);
               this.LCRadioButton.Name = "LCRadioButton";
               this.LCRadioButton.Size = new System.Drawing.Size(73, 17);
               this.LCRadioButton.TabIndex = 12;
               this.LCRadioButton.TabStop = true;
               this.LCRadioButton.Text = "Line Chart";
               this.LCRadioButton.UseVisualStyleBackColor = true;
               // 
               // BCRadioButton
               // 
               this.BCRadioButton.AutoSize = true;
               this.BCRadioButton.Location = new System.Drawing.Point(6, 41);
               this.BCRadioButton.Name = "BCRadioButton";
               this.BCRadioButton.Size = new System.Drawing.Size(69, 17);
               this.BCRadioButton.TabIndex = 13;
               this.BCRadioButton.TabStop = true;
               this.BCRadioButton.Text = "Bar Chart";
               this.BCRadioButton.UseVisualStyleBackColor = true;
               // 
               // CsCRadioButton
               // 
               this.CsCRadioButton.AutoSize = true;
               this.CsCRadioButton.Location = new System.Drawing.Point(6, 64);
               this.CsCRadioButton.Name = "CsCRadioButton";
               this.CsCRadioButton.Size = new System.Drawing.Size(108, 17);
               this.CsCRadioButton.TabIndex = 14;
               this.CsCRadioButton.TabStop = true;
               this.CsCRadioButton.Text = "Candlestick Chart";
               this.CsCRadioButton.UseVisualStyleBackColor = true;
               // 
               // ChartTypeSelection
               // 
               this.ChartTypeSelection.Controls.Add(this.CsCRadioButton);
               this.ChartTypeSelection.Controls.Add(this.BCRadioButton);
               this.ChartTypeSelection.Controls.Add(this.LCRadioButton);
               this.ChartTypeSelection.Location = new System.Drawing.Point(135, 12);
               this.ChartTypeSelection.Name = "ChartTypeSelection";
               this.ChartTypeSelection.Size = new System.Drawing.Size(116, 87);
               this.ChartTypeSelection.TabIndex = 15;
               this.ChartTypeSelection.TabStop = false;
               this.ChartTypeSelection.Text = "Chart Types";
               // 
               // ConsructButton
               // 
               this.ConsructButton.Location = new System.Drawing.Point(12, 278);
               this.ConsructButton.Name = "ConsructButton";
               this.ConsructButton.Size = new System.Drawing.Size(75, 23);
               this.ConsructButton.TabIndex = 16;
               this.ConsructButton.Text = "Construct";
               this.ConsructButton.UseVisualStyleBackColor = true;
               this.ConsructButton.Click += new System.EventHandler(this.ConsructButton_Click);
               // 
               // ChartPanel
               // 
               this.ChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.ChartPanel.Location = new System.Drawing.Point(257, 12);
               this.ChartPanel.Name = "ChartPanel";
               this.ChartPanel.Size = new System.Drawing.Size(637, 289);
               this.ChartPanel.TabIndex = 17;
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.Control;
               this.ClientSize = new System.Drawing.Size(906, 314);
               this.Controls.Add(this.ChartPanel);
               this.Controls.Add(this.ConsructButton);
               this.Controls.Add(this.ChartTypeSelection);
               this.Controls.Add(this.DataSelection);
               this.Controls.Add(this.ToDateTimePicker);
               this.Controls.Add(this.FromDateTimePicker);
               this.Margin = new System.Windows.Forms.Padding(2);
               this.Name = "Form2";
               this.Text = "Create a new graph";
               ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
               this.DataSelection.ResumeLayout(false);
               this.DataSelection.PerformLayout();
               this.ChartTypeSelection.ResumeLayout(false);
               this.ChartTypeSelection.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.BindingSource masterDataSetBindingSource;
          private masterDataSet masterDataSet;
          private System.Windows.Forms.RadioButton AirTempRadioButton;
          private System.Windows.Forms.RadioButton CO2RadioButton;
          private System.Windows.Forms.RadioButton HumidityRadioButton;
          private System.Windows.Forms.RadioButton IlluminationRadioButton;
          private System.Windows.Forms.RadioButton PHRadioButton;
          private System.Windows.Forms.RadioButton SoilMoistRadioButton;
          private System.Windows.Forms.RadioButton SoilTempRadioButton;
          private System.Windows.Forms.DateTimePicker FromDateTimePicker;
          private System.Windows.Forms.DateTimePicker ToDateTimePicker;
          private System.Windows.Forms.GroupBox DataSelection;
          private System.Windows.Forms.RadioButton LCRadioButton;
          private System.Windows.Forms.RadioButton BCRadioButton;
          private System.Windows.Forms.RadioButton CsCRadioButton;
          private System.Windows.Forms.GroupBox ChartTypeSelection;
          private System.Windows.Forms.Button ConsructButton;
          private System.Windows.Forms.Panel ChartPanel;
     }
}