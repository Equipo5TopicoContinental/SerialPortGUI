using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortGUI
{
    public partial class Form1 : Form
    {
        private byte b1, b2, b3;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_load;
            Control.CheckForIllegalCrossThreadCalls = false;
            b1 = (byte)0;
            b2 = (byte)0;
            b3 = (byte)0;
        }
        private void Form1_load(object sender, EventArgs e)
        {
            setCmbMessageID();
            setCmbFunctionality();
            setCmbFwBw();
            setCmbPlay();
            puertosDisponibles();
            cmbFunctionality.Hide();
        }

        private void puertosDisponibles()
        {
            foreach (string puertosDisponibles in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(puertosDisponibles);
            }
        }

        private void setCmbMessageID()
        {
            cmbMessageID.Items.Add("CMD");
            cmbMessageID.Items.Add("EQU");
            cmbMessageID.Items.Add("Album");
        }
        private void setCmbFunctionality()
        {
            if (cmbMessageID.SelectedIndex == 0)
            {
                cmbFunctionality.Items.Add("Play");
                cmbFunctionality.Items.Add("Pause");
                cmbFunctionality.Items.Add("Stop");
                cmbFunctionality.Items.Add("FW");
                cmbFunctionality.Items.Add("BW");
                cmbFunctionality.Items.Add("Skip");
                cmbFunctionality.Items.Add("Prev");
                cmbFunctionality.Items.Add("Reserved");
            }
            if(cmbMessageID.SelectedIndex == 1) {
                cmbFunctionality.Items.Add("Agudos");
                cmbFunctionality.Items.Add("Medios");
                cmbFunctionality.Items.Add("Bajos");
            }
        }
        private void setCmbFwBw()
        {
            cmbFwBw.Items.Add("100ms");
            cmbFwBw.Items.Add("50ms");
            cmbFwBw.Items.Add("20ms");
            cmbFwBw.Items.Add("400ms");
        }

        private void setCmbPlay()
        {
            cmbPlay.Items.Add("500ms");
            cmbPlay.Items.Add("200ms");
            cmbPlay.Items.Add("10ms");
            cmbPlay.Items.Add("1ms");
        }
        private void cmbPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbPuertos.Text;
            cmbPuertos.Enabled = false;
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione otro puerto", "Puerto no disponible");
                cmbPuertos.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            /*try
            {
                serialPort1.Write(txtTx.Text.Trim());
                txtTx.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar la información", "Error");
            }*/
            byte[] message = generaMensaje();
            try
            {
                txtTx.Text = message.ToString();
                serialPort1.Write(message, 3, 3);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar la información", "Error");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string datosRx = serialPort1.ReadExisting();
            txtRx.Text = datosRx;
        }

        private byte[] generaMensaje()
        {
            switch (cmbMessageID.SelectedIndex)
            {
                case 0:
                    b1 = 0x26;
                    b2 = (byte)cmbFunctionality.SelectedIndex;
                    switch (cmbFwBw.SelectedIndex)
                    {
                        case 0:
                            b2 += (byte)0;
                            break;
                        case 1:
                            b2 += (byte)8;
                            break;
                        case 2:
                            b2 += (byte)16;
                            break;
                        case 3:
                            b2 += (byte)24;
                            break;
                        default:
                            break;
                    }
                    if (cmbPlay.SelectedIndex == 0) b2 += (byte)0;
                    if (cmbPlay.SelectedIndex == 1) b2 += (byte)32;
                    break;
                case 1:
                    b1 = 0x66;
                    /*switch(){
                    }*/
                    break;
                case 2:
                    b1 = 0x44;
                    break;
                default: break;
            }

            

            b3 = (byte)(b1 ^ b2);

            byte[] message = new byte[3];
            message[0] = b1;
            message[1] = b2;
            message[2] = b3;

            return message;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void cmbMessageID_MouseClick(object sender, MouseEventArgs e)
        {
            cmbFunctionality.Items.Clear();
            cmbFunctionality.Show();
            //setCmbFunctionality();
        }

        private void cmbFunctionality_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMessageID_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void cmbFunctionality_MouseMove(object sender, MouseEventArgs e)
        {
            cmbFunctionality.Items.Clear();
            cmbFunctionality.Show();
            setCmbFunctionality();
        }

    }
}
