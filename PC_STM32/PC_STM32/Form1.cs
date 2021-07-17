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
namespace PC_STM32
{
    public partial class Form1 : Form
    {
        UInt16 m;
        string dataIN;
        int n,payload;
        char[] buffertx;
        byte[] rxbuffer = new byte[25];
        byte[] dataToProcess = new byte[25];
        int databuf_conut = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
           chBoxAlwaysUpdata.Checked = true;
           chBoxAddtoaddDta.Checked = false;
            lblComportStatus.Text = "Disconnect";

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARATYBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblComportStatus.Text = "Connected";
                clearBuffer(rxbuffer, 25); // 25 is maximun length of frame receive
                clearBuffer(dataToProcess, 25);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblComportStatus.Text = "Disconnet";

            }
        }
      

        private void btnDataOUT_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                if(((Convert.ToInt16(tBoxAddress.Text) >> 8) & 0x00FF) > 1)
                {
                    lblAdressStatus.Text = "Address out of range! Please try again.";
                }
            else
                {

                    lblAdressStatus.Text = "Valid";
                int m = n + 12;
                n = tBoxData.TextLength;
                int payload = n + 2;
                byte[] dataOUT = new byte[m];
                string data = tBoxData.Text;   
                char[] buffertx = new char[n];
                char[] charArr = data.ToCharArray();
                for (int i = 0; i < n; i++)
                {
                    buffertx[i] = data[i];      
                }
                dataOUT[0] = (byte)'E';
                dataOUT[1] = (byte)'E';
                dataOUT[2] = (byte)'P';
                dataOUT[3] = (byte)'W';
                dataOUT[4] = (byte)((Convert.ToInt16(payload) >> 8) & 0x00FF);
                dataOUT[5] = (byte)(Convert.ToInt16(payload) & 0x00FF);
                dataOUT[6] = (byte)((Convert.ToInt16(tBoxAddress.Text) >> 8) & 0x00FF);
                dataOUT[7] = (byte)(Convert.ToInt16(tBoxAddress.Text) & 0x00FF);
                for (int i = 8, j=0; i <m-4; i++)
                {
                    dataOUT[i] = (byte)buffertx[j];
                    j++;
                }
                dataOUT[m-4] = (byte)'$';
                dataOUT[m-3] = (byte)'$';
                dataOUT[m-2] = (byte)'$';
                dataOUT[m-1] = (byte)'$';
                serialPort1.Write(dataOUT, 0, m);
               
                for (int i=0; i < m; i++ )
                    {
                        Console.Write(" byte data thu %d la : " + Convert.ToString(dataOUT[i]) + '\n');
                      
                    }


                }

            }
        }
         private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if(tBoxDataIN.Text !="")
            {
                tBoxDataIN.Text = "";
            }
        }
          
        
       
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            serialPort1.Read(rxbuffer, 0, 25);
            serialPort1.DiscardInBuffer();
            
            if(this.IsDisposed || this.Disposing)
            {
                return;
            }
            
            else
            {
                this.Invoke(new EventHandler(ShowData));
            }
    
            /*
            {
                this.Invoke(new EventHandler(ShowData));
            }
 
        }

        private void ShowData(object sender, EventArgs e)
        
        {

            int dataLen = 0;
            byte[] dataIn = new byte[25];
            clearBuffer(dataIn, 25);
            int _i = 0, _j = 0;
            int endAt = 0xFF, beginAt = 0xFF;
            int strInLen = charArrLen(rxbuffer);
   
        }
        private int charArrLen(byte[] _buff)
        {
            int _i = 0, _len = 0, _sizeOfBuffer = 25;
            for (_i = 0; _i < _sizeOfBuffer; _i++)
            {
                if (_buff[_i] != 0)
                    _len = _i;
            }
            return _len + 1;
        }
        private void clearBuffer(byte[] _buff, int _sizeOfBuffer)
        {
            int _i = 0;
            for(_i = 0; _i < _sizeOfBuffer; _i++)
            {
                _buff[_i] = 0;
            }
        }

            /*
            if (chBoxAddtoaddDta.Checked)
            {
                tBoxDataIN.Text = dataIN;
            }
            else if (chBoxAddtoaddDta.Checked)
            {
                tBoxDataIN.Text  = tBoxDataIN + dataIN;
            }
            */
        }

        private void ShowData(object sender, EventArgs e)
        {
            int strInLen = charArrLen(rxbuffer);
            byte[] dataReceive = new byte[strInLen - 10];
            int dataLen = 0;
            byte[] dataIn = new byte[25];
            clearBuffer(dataIn, 25);
            int _i = 0, _j = 0;
            int endAt = 0xFF, beginAt = 0xFF;
           
            for(_i = 0; _i < strInLen; _i++)
            {
                dataToProcess[databuf_conut] = rxbuffer[_i];
                databuf_conut = (databuf_conut + 1) % 25;
            }
            clearBuffer(rxbuffer, 25);
            for (_i = 0; _i < 25; _i++)
            {
                if ((dataToProcess[_i] == '$') && (dataToProcess[fixPosition(_i - 1, 25)] == '$') && (dataToProcess[fixPosition(_i - 2, 25)] == '$') && (dataToProcess[fixPosition(_i - 3, 25)] == '$'))
                {
                    endAt = _i;
                }
            }
            if(endAt != 0xFF)
            {
                for(_i = 0; _i < 25; _i++)
                {
                    _j = fixPosition(endAt - _i, 25);
                    if ((dataToProcess[_j] == 'E') && (dataToProcess[(_j + 1) % 25] == 'E') && (dataToProcess[(_j + 2) % 25] == 'P') && (dataToProcess[(_j + 3) % 25] == 'R'))
                    {
                        beginAt = _j;
                    }
                }
            }
        if(beginAt != 0xFF)
            {
               for(int _m = beginAt + 6; _m < strInLen; _m++)
                {
                    dataReceive[_m] = dataToProcess[_m];
                }
                if (chBoxAddtoaddDta.Checked)
                {
                    tBoxDataIN.Text = Convert.ToString(dataReceive);
                }
                else if (chBoxAddtoaddDta.Checked)
                {
                    tBoxDataIN.Text += Convert.ToString(dataReceive);
                }

            }
        }
        private void clearBuffer(byte[] _buff, int _sizeOfBuffer)
        {
            int _i = 0;
            for (_i = 0; _i < _sizeOfBuffer; _i++)
            {
                _buff[_i] = 0;
            }
        }
        private int charArrLen(byte[] _buff)
        {
            int _i = 0, _len = 0, _sizeOfBuffer = 25;
            for (_i = 0; _i < _sizeOfBuffer; _i++)
            {
                if (_buff[_i] != 0)
                    _len = _i;
            }
            return _len + 1;
        }
        private int fixPosition(int _pos, int _sizeOfBuffer)
        {
            if (_pos < 0)
                _pos = (_pos + _sizeOfBuffer);
            _pos = _pos % 25;
            return _pos;
        }


        private void chBoxAlwaysUpdata_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAlwaysUpdata.Checked)
            {
                chBoxAlwaysUpdata.Checked = true;
                chBoxAddtoaddDta.Checked = false;
            }
            else
            {
                chBoxAddtoaddDta.Checked = true;
            }
        }

        private void chBoxAddtoaddDta_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAddtoaddDta.Checked)
            {
                chBoxAddtoaddDta.Checked = true;
                chBoxAlwaysUpdata.Checked = false;
            }
            else
            {
                chBoxAlwaysUpdata.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (((Convert.ToInt16(tBoxAddressRead.Text) >> 8) & 0x00FF) > 1)
                {
                    lblAddressRead.Text = "Address out of range! Please try again.";
                }
                else
                {
                    lblAddressRead.Text = "Valid";


                    if (((Convert.ToInt16(tBoxNumByteRead.Text) >> 8) & 0x00FF) > 1)
                    {
                        lblNumByteRead.Text = "Address out of range! Please try again.";
                    }
                    else
                    {
                        lblNumByteRead.Text = "Valid";
                        byte[] buffrx = new byte[8];
                        buffrx[0] = (byte)'E';
                        buffrx[1] = (byte)'E';
                        buffrx[2] = (byte)'P';
                        buffrx[3] = (byte)'R';
                        buffrx[4] = (byte)((Convert.ToInt16(tBoxAddressRead.Text) >> 8) & 0x00FF);
                        buffrx[5] = (byte)(Convert.ToInt16(tBoxAddressRead.Text) & 0x00FF);
                        buffrx[6] = (byte)((Convert.ToInt16(tBoxNumByteRead.Text) >> 8) & 0x00FF);
                        buffrx[7] = (byte)(Convert.ToInt16(tBoxNumByteRead.Text) & 0x00FF);

                        serialPort1.Write(buffrx, 0, 8);
                    }


                   
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            int dataINLength = tBoxDataIN.TextLength;
            lbldataINLength.Text = string.Format("{0:00}", dataINLength);

        }

        private void tBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
