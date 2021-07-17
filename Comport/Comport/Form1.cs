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

namespace Comport
{
    public partial class Form1 : Form
    {
        string dataOUT;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComport.Items.AddRange(ports);

            chBoxdtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxrstEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
             if(serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.WriteLine(dataOUT); 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComport.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParatyBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(tBoxDataOut.Text!="")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void chBoxdtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxdtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chBoxrstEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxrstEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int DataOutLength = tBoxDataOut.TextLength;
            lblDataOutLength.Text = string.Format("{0:00}", DataOutLength);

        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;
            }
            else
            {
                btnSendData.Enabled = false;
            }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
