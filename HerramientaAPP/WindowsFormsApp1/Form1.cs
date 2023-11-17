using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		System.IO.Ports.SerialPort Port;
		bool IsClosed = false;
		bool HayDispositivos;
		FilterInfoCollection MisDispocitivos;
		VideoCaptureDevice MiCamara;

		public Form1()
		{
			InitializeComponent();

			Port = new System.IO.Ports.SerialPort();
			Port.PortName = "COM1";
			Port.BaudRate = 9600;
			Port.ReadTimeout = 500;
			comboBox1.DataSource = SerialPort.GetPortNames();
			try
			{
				Port.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("este error" + ex);
			}

			CargarCamaras();


		}
	
		private void Form1_Load(object sender, EventArgs e)
		{
			Thread hilo = new Thread(EscucharSerial);
			hilo.Start();
			lblPuertoCom.Text = Port.PortName ;
			lblBaudios.Text = Port.BaudRate.ToString();

			chart1.Series.Add("Temp Superior");
			chart2.Series.Add("Temp Inferior");

		}

		private void EscucharSerial()
		{
			while (!IsClosed) 
			{
				string tempSup = string.Empty;
				string tempInf = string.Empty;
				string VoltajeSensor = string.Empty;
				try
				{
					string cadena = Port.ReadLine();
					string buscaSensor = cadena.Substring(0,10);

					if (buscaSensor.Equals("Sensor 1: "))
					{

						tempSup = cadena.Substring(0, cadena.IndexOf("\r"));
						lblTemperaturaSuperior.Invoke(new MethodInvoker(
						delegate
						{


						lblTemperaturaSuperior.Text = tempSup;
							string palcharoe = tempSup.Substring(10,2);
							
							int palchar = Convert.ToInt32(palcharoe);

							chart1.Series[0].Points.Add(palchar);

						}
						));
					}
					else
					{
						if (buscaSensor.Equals("Sensor 2: "))
						{

							tempInf = cadena.Substring(0, cadena.IndexOf("\r"));
							lblTemperaturaInferior.Invoke(new MethodInvoker(
							delegate
							{



								lblTemperaturaInferior.Text = tempInf;
								string palcharoe = tempInf.Substring(10, 2);

								int palchar = Convert.ToInt32(palcharoe);

								chart2.Series[0].Points.Add(palchar);
								//chart1.Series[1].Points.AddXY(tempInf);

							}
							));
						}
					}
					if (buscaSensor.Equals("Sensor 3: "))
					{

						VoltajeSensor = cadena.Substring(0, cadena.IndexOf("\r"));
						String mostrar = VoltajeSensor.Substring(10, 4);
						textBoxVoltage.Invoke(new MethodInvoker(
						delegate
						{

							textBoxVoltage.Text = mostrar;
							

						}
						));
					}
				

				
				}
				catch 
				{

				}

			
			}

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			IsClosed = true;

			if (Port.IsOpen) 
			{
				Port.Close();
			}
			cerrarCamara();
				

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblPuertoCom.Text = comboBox1.Text;
			lblBaudios.Text = cBoxBaudios.Text;
			chart1.ResetAutoValues();
			Port.Close();
			Port.PortName = comboBox1.Text;
			Port.BaudRate = 9600;
			Port.ReadTimeout = 500;
			Port.Open();
		}

		public void CargarCamaras()
		{
			MisDispocitivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (MisDispocitivos.Count > 0)
			{
				HayDispositivos = true;
				for (int i = 0; i < MisDispocitivos.Count; i++)
				{
					cBoxCamaras.Items.Add(MisDispocitivos[i].Name.ToString());
					cBoxCamaras.Text = MisDispocitivos[0].Name.ToString();
				}
			}
			else
			{
				HayDispositivos = false;
			}
		}
		public void cerrarCamara()
		{
			if(MiCamara!=null && MiCamara.IsRunning)
			{
				MiCamara.SignalToStop();
				MiCamara = null;
			}
		}

		private void cBoxCamaras_SelectedIndexChanged(object sender, EventArgs e)
		{
			cerrarCamara();
			int i = comboBox1.SelectedIndex;
			string nombreCamara = MisDispocitivos[i].MonikerString;
			MiCamara = new VideoCaptureDevice(nombreCamara);
			MiCamara.NewFrame += new NewFrameEventHandler(Capturando);
			MiCamara.Start();

		}
		private void Capturando(Object sender , NewFrameEventArgs eventArgs)
		{
			Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
			PBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			PBox1.Image = imagen;
		}
	}
}
