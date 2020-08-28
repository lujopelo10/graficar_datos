using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;// para poder trabajar con los serial ports es necesario incluir esta libreria

namespace graficar_datos
{
    public partial class Form1 : Form
    {
        string dato;

        public Form1()
        {
            InitializeComponent();
            int baudios = serialPort1.BaudRate;
            string portname;
            bool modo = serialPort1.IsOpen;
            portname = serialPort1.PortName;
            //serialPort1.DiscardInBuffer();
            //serialPort1.Dispose();

            serialPort1.Close();
            btn_toConnect.Enabled = false;
            btn_toConnect.BackColor = System.Drawing.Color.Red;
            lblShowingPorts.Text = "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString();
            lbl_ShowSerialPortData.Text= "estatus del puerto" + " "+ portname +" " + modo.ToString() + " " + baudios.ToString();
        }

        private void bt_GetSerialPOrts_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames(); //Obtenermos una lista de los serial ports disponibles y la guardamos en la varible "ports"

                cbSerialPortsAva.Items.Clear();
                cbSerialPortsAva.ResetText();

                foreach (string port in ports)//para cada cadena obtenida la asignamos en la variable port y la añadismo a los items de comboBox

                {
                    cbSerialPortsAva.Items.Add(port);      //añadimos los nobres de los puertos disponibles al ListBox
                }

                lblShowingPorts.Text= "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString();
                if (cbSerialPortsAva.Items.Count > 0)
                {
                    bt_GetSerialPOrts.BackColor = System.Drawing.Color.Red;
                    bt_GetSerialPOrts.Enabled = false;
                    btn_toConnect.Enabled = true;
                    btn_toConnect.BackColor = System.Drawing.Color.Green;
                }

            }

            




            catch (Exception)
            {

                MessageBox.Show("No se obtuvieron puertos disponibles"); ;
            }
        }

        

        

        private void btn_toConnect_Click(object sender, EventArgs e)
        {
            

          try
            {


                //if (serialPort1.IsOpen == true || btn_toConnect.Text == "Disconnect")
                //{
                //    btn_toConnect.Text = "Connect";
                //    btn_toConnect.BackColor = System.Drawing.Color.Red;

                //    serialPort1.DiscardInBuffer();
                //    serialPort1.Dispose();
                //    serialPort1.PortName = "";
                //    serialPort1.Close();
                //}
                

                if (serialPort1.IsOpen == false && cbSerialPortsAva.Items.Count > 0 && cbSerialPortsAva.Text != "" && btn_toConnect.Text == "Connect")
                {
                    string portname;
                    serialPort1.PortName = cbSerialPortsAva.Text;
                    serialPort1.Open();
                    bool modo = serialPort1.IsOpen;
                    portname = serialPort1.PortName;
                    btn_toConnect.Text = "Disconnect";
                    btn_toConnect.BackColor = System.Drawing.Color.Red;
                    //serialPort1.PortName = cbSerialPortsAva.Text;
                    lblShowingPorts.Text= "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString() + " " + cbSerialPortsAva.Text;
                    lbl_ShowSerialPortData.Text = "estatus del puerto" + " " + portname +" " + modo.ToString();
                   // serialPort1.Open();
                }
                else
                {
                    MessageBox.Show("entro al else");
                    btn_toConnect.Text = "Connect";
                    cbSerialPortsAva.Text = "";
                    lblShowingPorts.Text = "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString() + " " + cbSerialPortsAva.Text;
                    btn_toConnect.BackColor = System.Drawing.Color.Green;
                    bt_GetSerialPOrts.Enabled = true;
                    bt_GetSerialPOrts.BackColor = System.Drawing.Color.Green;
                    btn_toConnect.Enabled=false;
                    serialPort1.DiscardInBuffer();
                    serialPort1.Dispose();
                    
               serialPort1.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("estoy en exception");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                MessageBox.Show("recibiendo info");
                dato = serialPort1.ReadLine();
                Console.WriteLine(dato);
                lbl_ShowSerialPortData.Text = dato.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

        
    

    



           
