using System;
using System.IO.Ports;  //Agregar la libreria del Serial Port
using System.Threading;
using System.Windows.Forms;

namespace Arduino_N1
{
    public partial class Form1 : Form
    {

        bool IsClosed = false;
        int ban1 = 0;   // bandera para treeView Encender
        int ban2 = 0;   // bandera para treeView Apagar
        int ban3 = 0;   // bandera para saber si el arduino esta conectado
                       
        public Form1()  // constructor
        {
            InitializeComponent();

            // al iniciar todos los botones estan deshabilitados
            btn_encender.Enabled = false;
            btn_apagar.Enabled = false;
            btn_conectar.Enabled = false;
            btn_limpiar.Enabled = false;


            string[] PuertoDisponibles = SerialPort.GetPortNames();
            CboPuertos.Items.Clear(); //limpio el combobox
            foreach (String puerto_simple in PuertoDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple); // agrego los puertos
                                                     // detectados
            }
            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0; //selecciono el pruerto encontrado
                                              //como primera posicion
                btn_conectar.Enabled = true;  // habilito el boton conectar
            }
            else
            {
                MessageBox.Show("No se detecta ningun puerto de trabajo");
            }

        }
        
        private void btn_encender_Click(object sender, EventArgs e)
        {
            btn_encender.Enabled = false; // deshabilito el boton de ecendido
            btn_apagar.Enabled = true; // habilito el boton de apagado
            DateTime fecha = DateTime.Now; // cargo en una variable el DataTime
            try
            {
                SerPort.Write("E"); // Envia por el serial Port la letras "E"
                pictureBox1.Image = List_imagen.Images[0]; // cargo la imagen de ecendido
                if (ban1 == 0)
                {
                    treeView1.Nodes.Add("Encender"); // Agrego el primer nodo
                    ban1 = 1;
                }
                treeView1.Nodes[0].Nodes.Add(fecha.ToString()); // Agrego el datatime en el nodo
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            btn_encender.Enabled = true; // habilito el boton de ecendido
            btn_apagar.Enabled = false; // deshabilito el boton de apagado
            DateTime fecha1 = DateTime.Now; // cargo en una variable el DataTime
            try
            {
                SerPort.Write("S"); // Envia por el serial Port la letras "S"
                pictureBox1.Image = List_imagen.Images[1]; // Cargo la imagen de apagado 
                if (ban2 == 0)
                {
                    treeView1.Nodes.Add("Apagar"); // Agrego el Segundo nodo
                    ban2 = 1;
                }
                treeView1.Nodes[1].Nodes.Add(fecha1.ToString()); // Agrego el datatime en el nodo
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
                SerPort.Close();  //al Cerrar desactivo la comunicacion con el puerto
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();        //limpio el treeview
            ban1 = 0;
            ban2 = 0;
            btn_encender.Enabled = true; // habilito el boton de ecendido
            btn_apagar.Enabled = false;  // deshabilito el boton de apagado   

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
                            if (cadena == "0")
                            {                                
                                ban3 = 1; //el arduino esta conectado
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
            
            try
            {

                if (btn_conectar.Text == "Conectar Puerto")
                {
                    SerPort.BaudRate = 9600; //es la modo de trasferencia
                                             //por bit por segundo
                    SerPort.PortName = CboPuertos.Text; //declaro el tipo de COM
                                                        //que voy a utiliza
                    
                    try
                    {
                        SerPort.Open(); // activo la comunicacion con el SerialPort
                        btn_conectar.Text = "Desconectar";
                        btn_encender.Enabled = true;                     
                        btn_limpiar.Enabled = true;
                        CboPuertos.Enabled = false;
                        if (ban3 == 1) 
                        {
                            txt_EscucharSerial.Text = "Arduino Conectado";
                            //MessageBox.Show("si "+ban3);
                        }
                        else
                        {
                            txt_EscucharSerial.Text = "";
                            //MessageBox.Show("No " + ban3);
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                }
                else if (btn_conectar.Text == "Desconectar")
                {
                    SerPort.Close();
                    txt_EscucharSerial.Text = "";
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
