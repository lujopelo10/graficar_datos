using System;
using System.Windows.Forms;
using System.Security;
using System.Threading.Tasks;
using System.Threading;

using System.IO;
using System.IO.Ports;
/****************  LIBRERIAS NECESARIAS PARA LA EJECUCION DEMI PROGRAMA ***************/
namespace graficar_datos
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string dato, portname, fecha, hora, fecom;
        int tiempo = 3400,datum;
        double voltaje;
        double[] datos = new double[100];// en este vector se almacenararn los valores de voltaje para despues usarlos
        int[] tiempos = new int[30];// guardar los valor del tiempo
        string[] FyH = new string[30];
        string[,] tabla = new string[30, 3];


        public Form1()
        {


            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            InitializeComponent();// inicia los controles con los valores que se definieron en las propiedades de each one
            fecha = dateTimePicker1.Value.ToShortDateString();
            fecom = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:msms");
            hora = dateTimePicker1.Value.ToShortTimeString();
            timer1.Enabled = false;
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            datum = Convert.ToInt16(datos.Length);
            int baudios = serialPort1.BaudRate;//declaro la variable baudios del tipo entero y le asigno el valor de los baudios a los que trabaja el puerto
            bool modo = serialPort1.IsOpen;//declaro la vaarible modo del tipo bool para obtener el estado del puerto si es TRUE esta abierto; FALSE esta cerrado
            portname = serialPort1.PortName;//uso la varible portname para obtner el nombre del pueto serial con el que inicia

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //serialPort1.DiscardInBuffer();
            //serialPort1.Dispose();
            //serialPort1.Close();

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            chart1.Series[0].Points.Clear();//limpio los puntos a graficar en la propiedad series del chart1
            CheckForIllegalCrossThreadCalls = false;

            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            btn_toConnect.Enabled = false;//deshabilito el boton Connect
            btn_toConnect.BackColor = System.Drawing.Color.Red;//establezco el color Rojo de fondo del boton Connect
            lblShowingPorts.Text = "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString();//en la propiedad Text añado la cantidad de items en el Combobox donde añado los COM disponibles
            lbl_ShowSerialPortData.Text = "estatus del puerto" + " " + portname + " " + modo.ToString() + " " + baudios.ToString();//muestro el nombre del puerto COM mas el estatus (FALSE,TRUE) y los baudios velicidad
            cbSerialPortsAva.Items.Clear();
            cbSerialPortsAva.ResetText();
        }

            PostgreSQL conectandose = new PostgreSQL();

        /******************************************************************** EVENTOS DElPROGRAMA***************************************************************************************************/

        /******************************************************************** EVENTO CLICK BOTON GETSerialPorts***************************************************************************************************/

        private void bt_GetSerialPOrts_Click(object sender, EventArgs e)
        {
            try
            {
                cbSerialPortsAva.Items.Clear();//Limpio los Items que hayan estado añadidos al combobox
                cbSerialPortsAva.ResetText();//Limpio la propiedad text del combobox
                serialPort1.RtsEnable = true;
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                string[] ports = SerialPort.GetPortNames(); //Obtenermos una lista de los serial ports disponibles y la guardamos en la varible "ports"
                foreach (string port in ports)//para cada cadena obtenida la asignamos en la variable port y la añadismo a los items de comboBox

                {
                    cbSerialPortsAva.Items.Add(port);      //añadimos los nobres de los puertos disponibles al ListBox
                }
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                lblShowingPorts.Text = "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString();//obotnedo y muestro la cantidad de items dentro del combobox. Este caso, son SERIAL PORTS

                //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                if (cbSerialPortsAva.Items.Count > 0)//si en la propiedad Items el valor en cantidad de ellos mayor a 0
                {
                    bt_GetSerialPOrts.BackColor = System.Drawing.Color.Red;//Establzco el color Rojo con fondo en el boton GetSerialPorts
                    bt_GetSerialPOrts.Enabled = false;//Deshabilito el boton GetSerialPorts
                    btn_toConnect.Enabled = true;//Habilito el boton Connect
                    btn_toConnect.BackColor = System.Drawing.Color.Green;//Establezco el color verde en el fondo del boton Connect
                }

            }

            catch (Exception)
            {

                MessageBox.Show("No se obtuvieron puertos disponibles"); ;
            }
        }



        /******************************************************************** EVENTO CLICK BOTON CONNET***************************************************************************************************/

        private void btn_toConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false && cbSerialPortsAva.Items.Count > 0 && cbSerialPortsAva.Text != "" && btn_toConnect.Text == "Connect")//Si el SerialPort esta cerrado y la cantidad de Items en el combobox es mayor a 0 y
                                                                                                                                                      //en la propiedad Text del boton Connect esta "Connet"; Entonces, realizar el siguiente codigo
                {
                    //string portname;
                    int baudios = serialPort1.BaudRate;//DEclaro la varieble baudios del into entero y le asigno el valor de ls baudios del SerialPort
                    CheckForIllegalCrossThreadCalls = false;
                    btn_toConnect.Text = "Disconnect";//Cambio el valor de la propierdad TEXT a "Disconnect"
                    btn_toConnect.BackColor = System.Drawing.Color.Red;//Cambio el color de fondo del boton Connect a Rojo
                    serialPort1.PortName = cbSerialPortsAva.Text;//Asigno el el nombre al SerialPort Obteniendolo de la propiedad Text deol combobox
                    serialPort1.Open();
                    //Abro el SerialPort para el envio y recepcion de datos
                    //Thread.Sleep(100);
                    //    bool modo = serialPort1.IsOpen;//
                    //    portname = serialPort1.PortName;
                    //    
                    //    //serialPort1.PortName = cbSerialPortsAva.Text;
                    //    lblShowingPorts.Text= "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString() + " " + cbSerialPortsAva.Text;
                    //    lbl_ShowSerialPortData.Text = "estatus del puerto" + " " + portname + " " + modo.ToString() + " " + baudios.ToString();
                    //    // serialPort1.Open();
                    //    //Thread.Sleep(100);
                    //
                }
                else
                {
                    MessageBox.Show("entro al else");
                    btn_toConnect.Text = "Connect";
                    cbSerialPortsAva.Text = "";
                    dtgv_Consulta.DataSource = conectandose.Consultar();
                    cbSerialPortsAva.Items.Clear();//Limpio los Items que hayan estado añadidos al combobox
                    cbSerialPortsAva.ResetText();//Limpio la propiedad text del combobox
                    lblShowingPorts.Text = "Availables Serial Ports " + cbSerialPortsAva.Items.Count.ToString() + " " + cbSerialPortsAva.Text;
                    btn_toConnect.BackColor = System.Drawing.Color.Green;
                    bt_GetSerialPOrts.Enabled = true;
                    bt_GetSerialPOrts.BackColor = System.Drawing.Color.Green;
                    btn_toConnect.Enabled = false;
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
           /* tiempo = 202*/;
            try
            {
                // dato = serialPort1.ReadLine();
                //// MessageBox.Show(dato.ToString());
                // Console.WriteLine(dato);
                // lbl_ShowSerialPortData.Text = "estatus del puerto" + " " + portname + " "+ dato;//muestro el nombre del puerto COM mas el estatus (FALSE,TRUE) y los baudios velicidad
                //                                                                                 //lbl_ShowSerialPortData.Text = dato.ToString();
                //T/*hread.Sleep(100);*/
                tiempo++;
                dato = serialPort1.ReadLine();
                double numero = Convert.ToDouble(dato);
                voltaje = Math.Round(((numero * 5) / 1023), 2);
                conectandose.Insertar(Convert.ToInt32(tiempo), fecom, (Convert.ToString(voltaje)));
                chart1.Series["random"].Points.AddY(voltaje);
                lbl_ShowSerialPortData.Text = "estatus del puerto" + " " + portname + " " + voltaje.ToString();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString()); ;
            }
        }

        private void bt_GenerateRandomNum_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Guardando datos de Voltaje","CAPTANDO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i <100; i++)
                {
                    datos[i] = voltaje;
                }

            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
            
            //timer1.Enabled = true;
            //tiempo = 0;
            int t =3300;

            foreach (var dato in datos)
            {
                t++;
                //StreamWriter agregar = File.AppendText("LOG.txt");
                ////agregar.WriteLine(fecom+" "+ voltaje.ToString());
                //agregar.WriteLine(t.ToString() + " " + " hora" + " " + hora + "," + " voltaje" + " " + dato.ToString());
                ////agregar.WriteLine(dato.ToString());
                //agregar.WriteLine();
                //agregar.Close();

                //conectandose.Desconectar();
                conectandose.Insertar(Convert.ToInt32(t), fecom, (Convert.ToString(dato)));
                //lbl_timer.Text = t.ToString();
                //lbl_timer.Text = fecom;
                //lbl_timer.Text = dato.ToString();
                ///*hread.Sleep(100);*/

                dtgv_Consulta.DataSource = conectandose.Consultar();

            }
            //Console.WriteLine("Generating 10 random numbers:");

            DialogResult result = MessageBox.Show("Base de datos llena", "ENVIADO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (result==DialogResult.OK)

            {
                dtgv_Consulta.DataSource = conectandose.Consultar();
                //Close();
            }
            //for (uint ctr = 1; ctr <= 10; ctr++)
            //{
            //    MessageBox.Show($"{(random.Next() / 10000000),15:N0}");
            //}
        }
        //****************************************************************************************
        //  BOTON PARA CONECATR A LA BASE DE DATOS DE POSTGRES                                   *
        //                                                                                       * 
        //****************************************************************************************
        private void btn_OpenData_Click(object sender, EventArgs e)
        {
            try
            {
                //PostgresSQL conectandose = new PostgresSQL();
                conectandose.Conectar();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
            }
        }

        private void btn_CloseData_Click(object sender, EventArgs e)
        {
            try
            {

                conectandose.Desconectar();
            }
            catch (Exception y)
            {

                MessageBox.Show(y.ToString());
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {


            //tiempo++;

            
            //    MessageBox.Show("timer");
            //    StreamWriter agregar = File.AppendText("LOG.txt");
            //    //agregar.WriteLine(fecha +","+ voltaje.ToString());
            //agregar.WriteLine(fecha);
            //agregar.Close();

            //lbl_timer.Text = tiempo.ToString();

           
           
            //tiempo++;

            //tiempo = Convert.ToInt32(tiempo);
            //chart1.Series["random"].Points.AddY((random.Next()/ 10000000));
            //lbl_ShowRandomValue.Text = (random.Next() / 10000000).ToString();

            //if (tiempo ==20)
            //{
            //    tiempo = 0;

            //    chart1.Series[0].Points.Clear();
            // }


        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoGuardar = File.CreateText(txt);
                        //textoGuardar.Write(rTB_MostrarInfo.Text);
                        textoGuardar.Flush();
                        textoGuardar.Close();

                        TB_DIRECTION.Text = txt;

                    }

                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoGuardar = File.CreateText("LOG.txt");
                        //textoGuardar.Write(rTB_MostrarInfo.Text);
                        textoGuardar.Flush();
                        textoGuardar.Close();

                        TB_DIRECTION.Text = txt;

                    }

                    //timer1.Enabled = true;


                }


                //fecha = dateTimePicker1.Value.ToString();

                ////TextWriter Escribe = new StreamWriter("Log.txt");
                //StreamWriter textoGuardar = File.CreateText("LOG.txt");
                ////Escribe.WriteLine("Hola Mundo y todos");
                //MessageBox.Show("se creo el LOG");
                ////Escribe.Close();
                //textoGuardar.Close();

                ////StreamWriter agregar = File.AppendText("Text.txt");
                ////agregar.WriteLine("Listo, se agrego otra linea");
                ////agregar.Close();
                ////MessageBox.Show("listo");
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //tiempo++;
            ////agregar.Close();
            ////if (tiempo<=30)
            //if (tiempo==4)
            //{

            //    datos[tiempo] = voltaje;
            //    //tiempos[tiempo]= tiempo;
            //    ////FyH[tiempo] = hora + fecha;
            //    lbl_timer.Text = tiempo.ToString();
            //    //FyH[tiempo] = hora;
            //    //lbl_timer.Text = tiempo.ToString();
            //    //tiempo++;
                    
            //    //StreamWriter agregar = File.AppendText("LOG.txt");
            //    ////agregar.WriteLine(fecha +","+ voltaje.ToString());
            //    //agregar.WriteLine(tiempo.ToString()+" "+"Fecha y hora"+" "+fecha +hora+ "," +" voltaje"+" "+voltaje.ToString());
            //    //agregar.Close();

            //    //lbl_timer.Text = tiempo.ToString();
            //}

            //else
            //{
            //    int t = 0;
            //    //tiempo = 0;
               
            //    foreach (var dato in datos)
            //    {
            //        t++;
            //        //StreamWriter agregar = File.AppendText("LOG.txt");
            //        //agregar.WriteLine(fecom+" "+ voltaje.ToString());
            //        ////agregar.WriteLine(t.ToString() + " " + " hora" + " " + hora + "," + " voltaje" + " " + datos.ToString());
            //        ////agregar.WriteLine(dato.ToString());
            //        //agregar.WriteLine();
            //        //agregar.Close();

            //        conectandose.Desconectar();
            //        conectandose.Insertar(Convert.ToInt32(t),fecom,(Convert.ToString(dato)));
            //        lbl_timer.Text = t.ToString();
            //        lbl_timer.Text = fecom;
            //        lbl_timer.Text = dato.ToString();
            //        Thread.Sleep(100);

            //       // dtgv_Consulta.DataSource = conectandose.Consultar();

            //    }
                /*tiempo++*/

                //foreach (var tiempo in tiempos)
                //{
                //    tabla[t, 0] = dato.ToString();
                //    StreamWriter agregar = File.AppendText("LOG.txt");
                //    //agregar.WriteLine(fecha +","+ voltaje.ToString());
                //    agregar.WriteLine(tiempos.ToString() + " " + " hora" + " " + hora + "," + " voltaje" + " " + datos.ToString());
                //    agregar.WriteLine();
                //    agregar.Close();

                //    lbl_timer.Text = tiempo.ToString();
                //    timer1.Enabled = false;
                //}

                //timer1.Enabled = false;
                //MessageBox.Show("LOG Realizado");
        }

        

        private void btn_CLEARGRAPH_Click(object sender, EventArgs e)
        {
                      serialPort1.RtsEnable = false;
            //chart1.Series.Clear();
            chart1.Series["random"].Points.Clear();
        }
    }
}



        
    

 



           
