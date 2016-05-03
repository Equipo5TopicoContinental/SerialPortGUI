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
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_load;
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_load(object sender, EventArgs e)
        {
            setCmbMessageID();
            setCmbFunctionality();
            setCmbFwBw();
            setCmbPlay();
            setPorts();
            setCmbFreq();
            setCmbLvl();
            cmbFunctionality.Hide();
            cmbFreq.Hide();
            cmbFwBw.Hide();
            cmbLvl.Hide();
            cmbPlay.Hide();
            label7.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label8.Hide();
        }

        private void setPorts()
        {
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbPuertos.Items.Add(port);
            }
        }

        private void setCmbMessageID()
        {
            cmbMessageID.Items.Add("CMD");
            cmbMessageID.Items.Add("EQU");
            cmbMessageID.Items.Add("Album");
        }
        private void setCmbFreq()
        {
            cmbFreq.Items.Add("Agudos");
            cmbFreq.Items.Add("Medios");
            cmbFreq.Items.Add("Bajos");
        }
        private void setCmbLvl() {
            cmbLvl.Items.Add("Aumentar");
            cmbLvl.Items.Add("Disminuir");
        }
        private void setCmbFunctionality()
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
            byte[] message = generaMensaje().getData();
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

        private Message generaMensaje()
        {
            Message message;
            switch (cmbMessageID.SelectedIndex)
            {
                case 0:
                    message = new Message((byte)cmbMessageID.SelectedIndex, (byte)cmbFwBw.SelectedIndex, (byte)cmbPlay.SelectedIndex);
                    break;
                case 1:
                    message = new Message((byte)cmbFreq.SelectedIndex, (byte)cmbLvl.SelectedIndex);
                    break;
                case 2:
                    //message = new Message();
                    break;
                default: break;
            }
            return message = new Message(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cmbMessageID.SelectedIndex) {
                case 0:
                    cmbFwBw.Show();
                    cmbFreq.Hide();
                    cmbLvl.Hide();
                    cmbPlay.Show();
                    cmbFunctionality.Show();
                    label7.Hide();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    label8.Hide();
                    break;
                case 1:
                    cmbFreq.Show();
                    cmbLvl.Show();
                    cmbFwBw.Hide();
                    cmbPlay.Hide();
                    cmbFunctionality.Hide();
                    label7.Show();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    label8.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
