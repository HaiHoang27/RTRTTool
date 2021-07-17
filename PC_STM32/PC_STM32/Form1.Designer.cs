namespace PC_STM32
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxPARATYBITS = new System.Windows.Forms.ComboBox();
            this.CBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.cBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblComportStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDataOUT = new System.Windows.Forms.Button();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAddressRead = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxAddressRead = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbldataINLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxAddtoaddDta = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdata = new System.Windows.Forms.CheckBox();
            this.btnClearDataIN = new System.Windows.Forms.Button();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblAdressStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDataIN = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tBoxNumByteRead = new System.Windows.Forms.TextBox();
            this.lblNumByteRead = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.cBoxPARATYBITS);
            this.groupBox1.Controls.Add(this.CBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.cBoxDATABITS);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARATY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(92, 53);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.cBoxBAUDRATE.TabIndex = 4;
            this.cBoxBAUDRATE.Text = "9600";
            // 
            // cBoxPARATYBITS
            // 
            this.cBoxPARATYBITS.FormattingEnabled = true;
            this.cBoxPARATYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxPARATYBITS.Location = new System.Drawing.Point(92, 134);
            this.cBoxPARATYBITS.Name = "cBoxPARATYBITS";
            this.cBoxPARATYBITS.Size = new System.Drawing.Size(121, 21);
            this.cBoxPARATYBITS.TabIndex = 3;
            this.cBoxPARATYBITS.Text = "None";
            // 
            // CBoxSTOPBITS
            // 
            this.CBoxSTOPBITS.FormattingEnabled = true;
            this.CBoxSTOPBITS.Items.AddRange(new object[] {
            "One ",
            "Two"});
            this.CBoxSTOPBITS.Location = new System.Drawing.Point(92, 107);
            this.CBoxSTOPBITS.Name = "CBoxSTOPBITS";
            this.CBoxSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.CBoxSTOPBITS.TabIndex = 2;
            this.CBoxSTOPBITS.Text = "One";
            // 
            // cBoxDATABITS
            // 
            this.cBoxDATABITS.FormattingEnabled = true;
            this.cBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDATABITS.Location = new System.Drawing.Point(92, 80);
            this.cBoxDATABITS.Name = "cBoxDATABITS";
            this.cBoxDATABITS.Size = new System.Drawing.Size(121, 21);
            this.cBoxDATABITS.TabIndex = 1;
            this.cBoxDATABITS.Text = "8";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(92, 26);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            this.cBoxCOMPORT.Text = "COM1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(2, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblComportStatus);
            this.groupBox9.Location = new System.Drawing.Point(117, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(93, 85);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Com port Status";
            // 
            // lblComportStatus
            // 
            this.lblComportStatus.AutoSize = true;
            this.lblComportStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComportStatus.Location = new System.Drawing.Point(6, 37);
            this.lblComportStatus.Name = "lblComportStatus";
            this.lblComportStatus.Size = new System.Drawing.Size(83, 24);
            this.lblComportStatus.TabIndex = 0;
            this.lblComportStatus.Text = "Disconnect";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 22);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 67);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(99, 37);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDataOUT
            // 
            this.btnDataOUT.Location = new System.Drawing.Point(10, 18);
            this.btnDataOUT.Name = "btnDataOUT";
            this.btnDataOUT.Size = new System.Drawing.Size(78, 53);
            this.btnDataOUT.TabIndex = 2;
            this.btnDataOUT.Text = "SEND DATA OUT";
            this.btnDataOUT.UseVisualStyleBackColor = true;
            this.btnDataOUT.Click += new System.EventHandler(this.btnDataOUT_Click);
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Location = new System.Drawing.Point(103, 24);
            this.tBoxAddress.Multiline = true;
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(222, 24);
            this.tBoxAddress.TabIndex = 3;
            this.tBoxAddress.TextChanged += new System.EventHandler(this.tBoxAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data Transmit";
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(103, 83);
            this.tBoxData.Multiline = true;
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.Size = new System.Drawing.Size(222, 33);
            this.tBoxData.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblNumByteRead);
            this.groupBox3.Controls.Add(this.tBoxNumByteRead);
            this.groupBox3.Controls.Add(this.lblAddressRead);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tBoxAddressRead);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataIN);
            this.groupBox3.Location = new System.Drawing.Point(236, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 278);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver Pannel";
            // 
            // lblAddressRead
            // 
            this.lblAddressRead.AutoSize = true;
            this.lblAddressRead.Location = new System.Drawing.Point(101, 42);
            this.lblAddressRead.Name = "lblAddressRead";
            this.lblAddressRead.Size = new System.Drawing.Size(113, 13);
            this.lblAddressRead.TabIndex = 12;
            this.lblAddressRead.Text = "Please texting address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data Receive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Address";
            // 
            // tBoxAddressRead
            // 
            this.tBoxAddressRead.Location = new System.Drawing.Point(103, 19);
            this.tBoxAddressRead.Multiline = true;
            this.tBoxAddressRead.Name = "tBoxAddressRead";
            this.tBoxAddressRead.Size = new System.Drawing.Size(223, 20);
            this.tBoxAddressRead.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnClearDataIN);
            this.groupBox4.Location = new System.Drawing.Point(5, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 133);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbldataINLength);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(24, 89);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 35);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // lbldataINLength
            // 
            this.lbldataINLength.AutoSize = true;
            this.lbldataINLength.Location = new System.Drawing.Point(100, 22);
            this.lbldataINLength.Name = "lbldataINLength";
            this.lbldataINLength.Size = new System.Drawing.Size(19, 13);
            this.lbldataINLength.TabIndex = 9;
            this.lbldataINLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data IN Length:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxAddtoaddDta);
            this.groupBox5.Controls.Add(this.chBoxAlwaysUpdata);
            this.groupBox5.Location = new System.Drawing.Point(152, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 69);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // chBoxAddtoaddDta
            // 
            this.chBoxAddtoaddDta.AutoSize = true;
            this.chBoxAddtoaddDta.Location = new System.Drawing.Point(17, 43);
            this.chBoxAddtoaddDta.Name = "chBoxAddtoaddDta";
            this.chBoxAddtoaddDta.Size = new System.Drawing.Size(104, 17);
            this.chBoxAddtoaddDta.TabIndex = 3;
            this.chBoxAddtoaddDta.Text = "Add to odd Data";
            this.chBoxAddtoaddDta.UseVisualStyleBackColor = true;
            this.chBoxAddtoaddDta.CheckedChanged += new System.EventHandler(this.chBoxAddtoaddDta_CheckedChanged);
            // 
            // chBoxAlwaysUpdata
            // 
            this.chBoxAlwaysUpdata.AutoSize = true;
            this.chBoxAlwaysUpdata.Location = new System.Drawing.Point(17, 23);
            this.chBoxAlwaysUpdata.Name = "chBoxAlwaysUpdata";
            this.chBoxAlwaysUpdata.Size = new System.Drawing.Size(102, 17);
            this.chBoxAlwaysUpdata.TabIndex = 2;
            this.chBoxAlwaysUpdata.Text = "Always Updates";
            this.chBoxAlwaysUpdata.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdata.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdata_CheckedChanged);
            // 
            // btnClearDataIN
            // 
            this.btnClearDataIN.Location = new System.Drawing.Point(24, 28);
            this.btnClearDataIN.Name = "btnClearDataIN";
            this.btnClearDataIN.Size = new System.Drawing.Size(112, 58);
            this.btnClearDataIN.TabIndex = 1;
            this.btnClearDataIN.Text = "Clear Data IN";
            this.btnClearDataIN.UseVisualStyleBackColor = true;
            this.btnClearDataIN.Click += new System.EventHandler(this.btnClearDataIN_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(104, 93);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(222, 45);
            this.tBoxDataIN.TabIndex = 0;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblAdressStatus);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.tBoxData);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.tBoxAddress);
            this.groupBox7.Location = new System.Drawing.Point(237, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(342, 120);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Transmitter Pannel";
            // 
            // lblAdressStatus
            // 
            this.lblAdressStatus.AutoSize = true;
            this.lblAdressStatus.Location = new System.Drawing.Point(100, 56);
            this.lblAdressStatus.Name = "lblAdressStatus";
            this.lblAdressStatus.Size = new System.Drawing.Size(113, 13);
            this.lblAdressStatus.TabIndex = 8;
            this.lblAdressStatus.Text = "Please texting address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Status";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnDataIN
            // 
            this.btnDataIN.Location = new System.Drawing.Point(96, 18);
            this.btnDataIN.Name = "btnDataIN";
            this.btnDataIN.Size = new System.Drawing.Size(78, 53);
            this.btnDataIN.TabIndex = 10;
            this.btnDataIN.Text = "RECEIVE DATA IN";
            this.btnDataIN.UseVisualStyleBackColor = true;
            this.btnDataIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnDataIN);
            this.groupBox8.Controls.Add(this.btnDataOUT);
            this.groupBox8.Location = new System.Drawing.Point(12, 324);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 85);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Control Button";
            // 
            // tBoxNumByteRead
            // 
            this.tBoxNumByteRead.Location = new System.Drawing.Point(104, 65);
            this.tBoxNumByteRead.Name = "tBoxNumByteRead";
            this.tBoxNumByteRead.Size = new System.Drawing.Size(44, 20);
            this.tBoxNumByteRead.TabIndex = 13;
            // 
            // lblNumByteRead
            // 
            this.lblNumByteRead.AutoSize = true;
            this.lblNumByteRead.Location = new System.Drawing.Point(152, 69);
            this.lblNumByteRead.Name = "lblNumByteRead";
            this.lblNumByteRead.Size = new System.Drawing.Size(100, 13);
            this.lblNumByteRead.TabIndex = 15;
            this.lblNumByteRead.Text = "Please text number!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Number byte Read";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "C# COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.ComboBox cBoxPARATYBITS;
        private System.Windows.Forms.ComboBox CBoxSTOPBITS;
        private System.Windows.Forms.ComboBox cBoxDATABITS;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDataOUT;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxAddtoaddDta;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdata;
        private System.Windows.Forms.Button btnClearDataIN;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.TextBox tBoxAddressRead;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDataIN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAdressStatus;
        private System.Windows.Forms.Label lbldataINLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAddressRead;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblComportStatus;
        private System.Windows.Forms.TextBox tBoxNumByteRead;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNumByteRead;
    }
}

