using System;
using System.IO.Ports;  //Agregar la libreria del Serial Port
using System.Threading;
using System.Windows.Forms;

namespace Arduino_N1
{
    public partial class Form1 : Form
    {

        bool IsClosed = false;
        public Form1()  // constructor
        {
            InitializeComponent();

            btn_encender.Enabled = false;
            btn_apagar.Enabled = false;
            btn_conectar.Enabled = false;
            btn_limpiar.Enabled = false;


            string[] PuertoDisponibles = SerialPort.GetPortNames();
            CboPuertos.Items.Clear();
            foreach (String puerto_simple in PuertoDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);
            }
            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                btn_conectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se detecta ningun perto de trabajo");
            }

        }
        int ban1 = 0;
        int ban2 = 0;
        private void btn_encender_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now; // cargo en una variable el DataTime
            try
            {
                SerPort.Write("E");
                pictureBox1.Image = List_imagen.Images[0];
                if (ban1 == 0)
                {
                    treeView1.Nodes.Add("Encender");
                    ban1 = 1;
                }
                treeView1.Nodes[0].Nodes.Add(fecha.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsClosed = true;
            if (SerPort.IsOpen)
                SerPort.Close();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = DateTime.Now;
            try
            {
                SerPort.Write("S");
                pictureBox1.Image = List_imagen.Images[1];
                if (ban2 == 0)
                {
                    treeView1.Nodes.Add("Apagar");
                    ban2 = 1;
                }
                treeView1.Nodes[1].Nodes.Add(fecha1.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            ban1 = 0;
            ban2 = 0;

        }

        private void EscucharSerial()
        {
            while (!IsClosed)
            {
                try
                {
                    String cadena = SerPort.ReadLine();
                    txt_EscucharSerial.Invoke(new MethodInvoker(
                        delegate
                        {
                   //     txt_EscucharSerial.Text = cadena;
                            if (cadena =="0")
                            {
                                txt_EscucharSerial.Text = "Arduino Conectado";
                            }      
                        }
                        ));
                }
                catch
                {

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(EscucharSerial);
            Hilo.Start();

        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            txt_EscucharSerial.Text = "";
            try
            {
                
                if (btn_conectar.Text == "Conectar Puerto")
                {
                    SerPort.BaudRate = 9600;
                    SerPort.PortName = CboPuertos.Text;
                    try
                    {
                        SerPort.Open();
                        btn_conectar.Text = "Desconectar";                        
                        btn_encender.Enabled = true;
                        btn_apagar.Enabled = true;
                        btn_limpiar.Enabled = true;
                        CboPuertos.Enabled = false;                
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if (btn_conectar.Text == "Desconectar")
                {
                    SerPort.Close();
                    btn_conectar.Text = "Conectar Puerto";                    
                    btn_encender.Enabled = false;
                    btn_apagar.Enabled = false;
                    btn_limpiar.Enabled = false;
                    CboPuertos.Enabled = true;
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }
    }
}
