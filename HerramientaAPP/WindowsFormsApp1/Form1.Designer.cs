namespace WindowsFormsApp1
{
	partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxVoltage = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.lblTemperaturaInferior = new System.Windows.Forms.Label();
			this.lblTemperaturaSuperior = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblBaudios = new System.Windows.Forms.Label();
			this.lblPuertoCom = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.PBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cBoxCamaras = new System.Windows.Forms.ComboBox();
			this.cBoxBaudios = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBox1)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(98, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Voltage";
			// 
			// textBoxVoltage
			// 
			this.textBoxVoltage.Location = new System.Drawing.Point(176, 30);
			this.textBoxVoltage.Name = "textBoxVoltage";
			this.textBoxVoltage.Size = new System.Drawing.Size(124, 20);
			this.textBoxVoltage.TabIndex = 1;
			this.textBoxVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(72, 27);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(121, 13);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Cuadro de Herramientas";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBoxVoltage);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(733, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 101);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Multimetro";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chart2);
			this.groupBox2.Controls.Add(this.chart1);
			this.groupBox2.Controls.Add(this.lblTemperaturaInferior);
			this.groupBox2.Controls.Add(this.lblTemperaturaSuperior);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(41, 192);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1016, 452);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sensor Temperatura";
			// 
			// chart2
			// 
			this.chart2.BackColor = System.Drawing.Color.LightGray;
			chartArea5.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chart2.Legends.Add(legend5);
			this.chart2.Location = new System.Drawing.Point(217, 225);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			this.chart2.Size = new System.Drawing.Size(667, 219);
			this.chart2.TabIndex = 7;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.LightGray;
			this.chart1.BackSecondaryColor = System.Drawing.Color.Silver;
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
			this.chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
			chartArea6.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.chart1.Legends.Add(legend6);
			this.chart1.Location = new System.Drawing.Point(217, 19);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			this.chart1.Size = new System.Drawing.Size(667, 174);
			this.chart1.TabIndex = 6;
			this.chart1.Text = "Grafico Temp";
			// 
			// lblTemperaturaInferior
			// 
			this.lblTemperaturaInferior.AutoSize = true;
			this.lblTemperaturaInferior.Location = new System.Drawing.Point(38, 252);
			this.lblTemperaturaInferior.Name = "lblTemperaturaInferior";
			this.lblTemperaturaInferior.Size = new System.Drawing.Size(14, 13);
			this.lblTemperaturaInferior.TabIndex = 3;
			this.lblTemperaturaInferior.Text = "C";
			// 
			// lblTemperaturaSuperior
			// 
			this.lblTemperaturaSuperior.AutoSize = true;
			this.lblTemperaturaSuperior.Location = new System.Drawing.Point(38, 70);
			this.lblTemperaturaSuperior.Name = "lblTemperaturaSuperior";
			this.lblTemperaturaSuperior.Size = new System.Drawing.Size(14, 13);
			this.lblTemperaturaSuperior.TabIndex = 2;
			this.lblTemperaturaSuperior.Text = "C";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Temperatura Inferior";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Temperatura Superior";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.lblBaudios);
			this.groupBox3.Controls.Add(this.lblPuertoCom);
			this.groupBox3.Location = new System.Drawing.Point(49, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(329, 100);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Coneccion";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Velocidad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Puerto";
			// 
			// lblBaudios
			// 
			this.lblBaudios.AutoSize = true;
			this.lblBaudios.Location = new System.Drawing.Point(187, 65);
			this.lblBaudios.Name = "lblBaudios";
			this.lblBaudios.Size = new System.Drawing.Size(45, 13);
			this.lblBaudios.TabIndex = 1;
			this.lblBaudios.Text = "Baudios";
			// 
			// lblPuertoCom
			// 
			this.lblPuertoCom.AutoSize = true;
			this.lblPuertoCom.Location = new System.Drawing.Point(187, 36);
			this.lblPuertoCom.Name = "lblPuertoCom";
			this.lblPuertoCom.Size = new System.Drawing.Size(117, 13);
			this.lblPuertoCom.TabIndex = 0;
			this.lblPuertoCom.Text = "Puerto Com Conectado";
			this.lblPuertoCom.Click += new System.EventHandler(this.label4_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(150, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.cBoxBaudios);
			this.groupBox4.Controls.Add(this.comboBox1);
			this.groupBox4.Location = new System.Drawing.Point(407, 75);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(306, 100);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Config";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(73, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Puerto";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "BaudRate";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(92, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Corriente";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 66);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(124, 20);
			this.textBox1.TabIndex = 3;
			// 
			// PBox1
			// 
			this.PBox1.Location = new System.Drawing.Point(1080, 211);
			this.PBox1.Name = "PBox1";
			this.PBox1.Size = new System.Drawing.Size(243, 236);
			this.PBox1.TabIndex = 8;
			this.PBox1.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cBoxCamaras);
			this.groupBox5.Location = new System.Drawing.Point(1093, 75);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(230, 100);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Cam";
			// 
			// cBoxCamaras
			// 
			this.cBoxCamaras.FormattingEnabled = true;
			this.cBoxCamaras.Location = new System.Drawing.Point(29, 56);
			this.cBoxCamaras.Name = "cBoxCamaras";
			this.cBoxCamaras.Size = new System.Drawing.Size(170, 21);
			this.cBoxCamaras.TabIndex = 0;
			this.cBoxCamaras.SelectedIndexChanged += new System.EventHandler(this.cBoxCamaras_SelectedIndexChanged);
			// 
			// cBoxBaudios
			// 
			this.cBoxBaudios.FormattingEnabled = true;
			this.cBoxBaudios.Items.AddRange(new object[] {
            "9600",
            "115200"});
			this.cBoxBaudios.Location = new System.Drawing.Point(150, 65);
			this.cBoxBaudios.Name = "cBoxBaudios";
			this.cBoxBaudios.Size = new System.Drawing.Size(121, 21);
			this.cBoxBaudios.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1348, 648);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.PBox1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblTitulo);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cuadro de Instrumentos";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBox1)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxVoltage;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblTemperaturaInferior;
		private System.Windows.Forms.Label lblTemperaturaSuperior;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblPuertoCom;
		private System.Windows.Forms.Label lblBaudios;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox PBox1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ComboBox cBoxCamaras;
		private System.Windows.Forms.ComboBox cBoxBaudios;
	}
}

