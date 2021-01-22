using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComunicacionPuertosCom
{
    public partial class Form1 : Form
    {

        private delegate void DelegateAccess(String oString);

        private String bufferIn;
        private String bufferOut;
        private SerialPort serialPort1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.inicializarRecursos();
        }

        private void inicializarRecursos()
        {
            this.bufferIn = "";
            this.bufferOut = "";
            this.btnConectar.Enabled = false;
            this.btnEnviarDatos.Enabled = false;
        }

        private void btnBuscarPuertos_Click(object sender, EventArgs e)
        {
            String[] puertosDisponibles = SerialPort.GetPortNames();
            this.cmbPuertos.Items.Clear();

            foreach (String port in puertosDisponibles)
            {
                this.cmbPuertos.Items.Add(port);
            }

            if (this.cmbPuertos.Items.Count > 0)
            {
                this.cmbPuertos.SelectedIndex = 0;
                MessageBox.Show("Seleccionar puerto de trabajo");
                this.btnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ningun Puerto conectado");
                this.cmbPuertos.Items.Clear();
                this.inicializarRecursos();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "CONECTAR")
            {
                try
                {
                    this.serialPort1 = new SerialPort();
                    this.serialPort1.BaudRate = Int32.Parse(this.cmbBufferRate.Text);
                    this.serialPort1.DataBits = 8;
                    this.serialPort1.Parity = this.getParity(this.cmbParity.Text);
                    this.serialPort1.StopBits = this.getStopBits(this.cmbStopBits.Text);
                    this.serialPort1.PortName = this.cmbPuertos.Text;
                    this.serialPort1.Handshake = Handshake.None;
                    this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(getDataBascula);


                    this.serialPort1.Open();
                    this.btnConectar.Text = "DESCONECTAR";
                    this.btnEnviarDatos.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.btnConectar.Text == "DESCONECTAR")
            {
                this.serialPort1.Close();
                
                this.btnConectar.Text = "CONECTAR";
            }
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                this.serialPort1.DiscardOutBuffer();
                this.bufferOut = this.tbDatosEnviar.Text;
                this.serialPort1.Write(this.bufferOut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Parity getParity(String pariedad)
        {
            Parity oParity;
            switch (pariedad)
            {
                case "None":
                    oParity = Parity.None;
                    break;
                case "Odd":
                    oParity = Parity.Odd;
                    break;
                case "Even":
                    oParity = Parity.Even;
                    break;
                default:
                    oParity = Parity.None;
                    break;
            }
            return oParity;
        }

        private StopBits getStopBits(String stopBits)
        {
            StopBits oStopBits;
            switch (stopBits)
            {
                case "1":
                    oStopBits = StopBits.One;
                    break;
                case "2":
                    oStopBits = StopBits.Two;
                    break;
                default:
                    oStopBits = StopBits.One;
                    break;
            }
            return oStopBits;
        }

        private void getDataBascula(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort oSerialPort = (SerialPort)sender;
            this.handlerAddPesoForm(oSerialPort.ReadExisting());
        }

        private void addPesoForm(String peso)
        {
            this.bufferIn = peso;
            this.tbDatosRecibidos.Text = this.bufferIn;
        }

        private void handlerAddPesoForm(String peso)
        {
            DelegateAccess oDelegateAccess = new DelegateAccess(addPesoForm);
            object[] args = { peso };
            base.Invoke(oDelegateAccess, args);
        }

        
    }
}
