using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
namespace DemoZedgraph
{
    public partial class Form1 : Form
    {
        byte[] buffer = new byte[30];
        byte[] dataTransmit = new byte[10];
        double data_OUT;
        string demo;
        int velo_l1, velo_l2, velo_r1, velo_r2;
        

        Int16 speed = 123;
        double speed_set = 456;
        string dataIn;

        public Form1()
        {
            InitializeComponent();
        }
        int TickStart, intMode = 1;

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void Draw(String setpoint, string current)
        {
            // Tạo 1 curve
            double intsetpoint;
            double intcurrent;
            double.TryParse(setpoint, out intsetpoint);
            double.TryParse(current, out intcurrent);
            if (zed.GraphPane.CurveList.Count < 0)
                return;
            // Tạo item curve trong đồ thị
            LineItem curve = zed.GraphPane.CurveList[0] as LineItem;
            LineItem curve1 = zed.GraphPane.CurveList[1] as LineItem;
            if (curve == null)
                return;
            if (curve1 == null)
                return;

            //Lấy pointpairList
            IPointListEdit list = curve.Points as IPointListEdit;
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            if (list == null)
                return;
            if (list1 == null)
                return;
            double time = (Environment.TickCount - TickStart) / 1000.0;
            list.Add(time, intsetpoint);
            list1.Add(time, intcurrent);

            Scale xScale = zed.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (intMode == 1)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 30.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }

            }
            zed.AxisChange();
            zed.Invalidate();



        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);




            // Phần này đặt tên cho đồ thì và các trục
            GraphPane myPane = zed.GraphPane;
            myPane.Title.Text = "B";
            myPane.XAxis.Title.Text = "Time, Second";
            myPane.YAxis.Title.Text = "Van toc, m/s";
            myPane.YAxis.Scale.Min = 0;  // Set scale trục Y,X chút nữa set
            myPane.YAxis.Scale.Max = 3000;
            myPane.YAxis.Scale.MajorStep = 500;
            myPane.YAxis.Scale.MinorStep = 50;

            // Tạo khung hiện thì 2 đường tín hiệu 
            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);

            LineItem curve = myPane.AddCurve("Set Value", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPane.AddCurve("Current Value", list1, Color.Blue, SymbolType.None);

            // Tạo scale cho trục X
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            zed.AxisChange();
            TickStart = Environment.TickCount;

        }

        delegate void SetTextCallback(string text);
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Read(buffer, 0, 29);
                serialPort1.DiscardInBuffer(); // clear RX buffer khi đọc xong dữ liệu. không có cái này thì anlon
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { dataIn });// nhảy zô hàm settext
            }
        }
        private void SetText(string data)
        {
            UInt16 Data_in = 0;
            if (buffer[0]!=0x7F)
            {
                Data_in = (UInt16)((buffer[1] << 8) | (buffer[2]));
                // tính Speed
                // speed = caí đó

            }


        }

        private void sendRequest(Byte currentMode, UInt16 dataSet, Byte state)
        {
            dataTransmit[0] = (Byte)('!');
            dataTransmit[1] = (Byte)((currentMode << 4) | state);
            dataTransmit[2] = (Byte)(dataSet >> 8);
            dataTransmit[3] = (Byte)(dataSet & 0x00FF);
            UInt16 checkSum = 0;
            UInt32 check = (UInt32)(dataSet + ((currentMode << 4) | state));
            if ((check >> 16) == 1)
                checkSum = (UInt16)((check & 0x0000FFFF) + 1);
            else
                checkSum = (UInt16)(check & 0x0000FFFF);

            dataTransmit[4] = (Byte)(checkSum >> 8);
            dataTransmit[5] = (Byte)(checkSum & 0x00FF);

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(dataTransmit, 0, 8);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi Cmnr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.Open();

 
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bntClose_Click(object sender, EventArgs e)
        {

            if(serialPort1.IsOpen)
            {
                serialPort1.Close();

            }
        }

        private void btnSendSpeed_Click(object sender, EventArgs e)
        {
            demo = tBoxSpeedSet.Text;
            speed_set = Convert.ToDouble(tBoxSpeedSet.Text);
            
            velo_l1 = Convert.ToInt16(tBoxSpeedSet.Text);
            //velo_l1 = speed_set;
            velo_l2 = Convert.ToInt16(Convert.ToInt16(tBoxSpeedSet.Text) - velo_l1) * 10000;

            velo_r1 = Convert.ToInt16(tBoxSpeedSet.Text);
            velo_r2 = Convert.ToInt16(Convert.ToInt16(tBoxSpeedSet.Text) - velo_r1) * 10000;
            dataTransmit[0] = 205;
            dataTransmit[1] = Convert.ToByte(velo_l1);
            dataTransmit[2] = Convert.ToByte(velo_l2 & 0x00FF);
            dataTransmit[3] = Convert.ToByte((velo_l2 >> 8) & 0x00FF);

            dataTransmit[4] = Convert.ToByte(velo_r1);
            dataTransmit[5] = Convert.ToByte(velo_r2 & 0x00FF);
            dataTransmit[6] = Convert.ToByte((velo_r2 >> 8) & 0x00FF);
            dataTransmit[7] = 3;
            dataTransmit[8] = 204;

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(dataTransmit, 0, 9);
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

    


                //serialPort1.Write(demo);

                //data_OUT = Convert.ToDouble(tBoxSpeedSet.Text);
                //serialPort1.WriteLine(Convert.ToString(data_OUT));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                Draw(Convert.ToString(speed_set), Convert.ToString(speed));

            }

        }

    }
}
