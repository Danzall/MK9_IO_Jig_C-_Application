using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Jig
{
    public partial class Form1 : Form
    {
        string data;
        string s2 = "L,";
        bool b;
        string IGN_D = string.Empty;
        string IGN_T = string.Empty;
        string RPM_D = string.Empty;
        string RPM_T = string.Empty;
        string Panic_D = string.Empty;
        string Panic_T = string.Empty;
        string InuptA_D = string.Empty;
        string InuptA_T = string.Empty;
        string InuptB_D = string.Empty;
        string InuptB_T = string.Empty;
        string InuptC_D = string.Empty;
        string InuptC_T = string.Empty;
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            GetPorts();
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.debug.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {

                DateTime CurrentDate;
                //this.debug.Text += text + "\n";
                s2 = "Unit";
                b = text.Contains(s2);
                if (b)
                {
                    //this.debug.Text += "Jig ready\r";
                    jStatus.Text = "Jig ready\r";
                    //serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
                b = text.Contains("33");
                if (b)
                {
                    debug.Text = String.Empty;
                    
                    ClearAll();
                    jStatus.Text = "Jig busy\r";
                    this.debug.Text += "Test started\n";
                    IGN_D_S.Text = "P";
                    RPM_D_S.Text = "P";
                    Panic_D_S.Text = "P";
                    Input_A_D_S.Text = "P";
                    Input_B_D_S.Text = "P";
                    Input_C_D_S.Text = "P";

                }
                b = text.Contains("34");
                if (b)
                {
                    this.debug.Text += "Testing IGN\n";
                    progressBar1.Increment(11);
                    IGN_D_T.Text = "P";
                }
                b = text.Contains("35");
                if (b)
                {
                    this.debug.Text += "Testing RPM\n";
                    progressBar1.Increment(11);
                    RPM_D_T.Text = "P";
                }
                b = text.Contains("36");
                if (b)
                {
                    this.debug.Text += "Testing Panic\n";
                    progressBar1.Increment(11);
                    Panic_D_T.Text = "P";
                }
                b = text.Contains("37");
                if (b)
                {
                    this.debug.Text += "Testing Input A\n";
                    progressBar1.Increment(11);
                    Input_A_D_T.Text = "P";
                }
                b = text.Contains("38");
                if (b)
                {
                    this.debug.Text += "Testing Input B\n";
                    progressBar1.Increment(11);
                    Input_B_D_T.Text = "P";
                }
                b = text.Contains("39");
                if (b)
                {
                    this.debug.Text += "Testing Input C\n";
                    progressBar1.Increment(11);
                    Input_C_D_T.Text = "P";
                    //serialPort1.DiscardInBuffer();
                }
                b = text.Contains("3a");
                if (b)
                {
                    this.debug.Text += "Testing Outputs!!!!!\n";
                    Immob_D_S.Text = "P";
                    Output_D_S.Text = "P";
                    Tag_LED_D_S.Text = "P";
                }
                b = text.Contains("3b");
                if (b)
                {
                    this.debug.Text += "Testing Immob\n";
                    progressBar1.Increment(11);
                    Immob_D_T.Text = "P";
                }
                b = text.Contains("3c");
                if (b)
                {
                    this.debug.Text += "Testing Output\n";
                    progressBar1.Increment(11);
                    Output_D_T.Text = "P";
                }
                b = text.Contains("3d");
                if (b)
                {
                    this.debug.Text += "Testing Tag LED\n";
                    progressBar1.Increment(12);
                    Tag_LED_D_T.Text = "P";
                }
                b = text.Contains("complete");
                if (b)
                {
                    this.debug.Text += "Test complete\n";
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
                if (b)
                {

                    CurrentDate = DateTime.Now;
                    //CurrentDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy"));
                    //this.debug.Text += CurrentDate + " : ";
                    //this.debug.Text += text + "\n";
                }
                CheckDefault(text);
                CheckTrigerred(text);
            }
        }

        private void ClearAll()
        {
            debug.Text = String.Empty;
            IGN_D_S.Text = String.Empty;
            IGN_D_T.Text = String.Empty;
            RPM_D_S.Text = String.Empty;
            RPM_D_T.Text = String.Empty;
            Panic_D_S.Text = String.Empty;
            Panic_D_T.Text = String.Empty;
            Input_A_D_S.Text = String.Empty;
            Input_A_D_T.Text = String.Empty;
            Input_B_D_S.Text = String.Empty;
            Input_B_D_T.Text = String.Empty;
            Input_C_D_S.Text = String.Empty;
            Input_C_D_T.Text = String.Empty;

            Immob_D_S.Text = String.Empty;
            Immob_D_T.Text = String.Empty;
            Output_D_S.Text = String.Empty;
            Output_D_T.Text = String.Empty;
            Tag_LED_D_S.Text = String.Empty;
            Tag_LED_D_T.Text = String.Empty;
            progressBar1.Value = 0;

            IGN_D_S.BackColor = System.Drawing.SystemColors.Window;
            IGN_D_S.BackColor = System.Drawing.SystemColors.Window;
            IGN_D_T.BackColor = System.Drawing.SystemColors.Window;
            RPM_D_S.BackColor = System.Drawing.SystemColors.Window;
            RPM_D_T.BackColor = System.Drawing.SystemColors.Window;
            Panic_D_S.BackColor = System.Drawing.SystemColors.Window;
            Panic_D_T.BackColor = System.Drawing.SystemColors.Window;
            Input_A_D_S.BackColor = System.Drawing.SystemColors.Window;
            Input_A_D_T.BackColor = System.Drawing.SystemColors.Window;
            Input_B_D_S.BackColor = System.Drawing.SystemColors.Window;
            Input_B_D_T.BackColor = System.Drawing.SystemColors.Window;
            Input_C_D_S.BackColor = System.Drawing.SystemColors.Window;
            Input_C_D_T.BackColor = System.Drawing.SystemColors.Window;

            Immob_D_S.BackColor = System.Drawing.SystemColors.Window;
            Immob_D_T.BackColor = System.Drawing.SystemColors.Window;
            Output_D_S.BackColor = System.Drawing.SystemColors.Window;
            Output_D_T.BackColor = System.Drawing.SystemColors.Window;
            Tag_LED_D_S.BackColor = System.Drawing.SystemColors.Window;
            Tag_LED_D_T.BackColor = System.Drawing.SystemColors.Window;
        }

        private void CheckDefault(string input)
        {
            //this.debug.Text += "Check default\n";
            b = input.Contains("63");
            if (b)
            {
                IGN_D_S.Text = "F";
                IGN_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("64");
            if (b)
            {
                Panic_D_S.Text = "F";
                Panic_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("65");
            if (b)
            {
                Input_A_D_S.Text = "F";
                Input_A_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("66");
            if (b)
            {
                Input_B_D_S.Text = "F";
                Input_B_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("67");
            if (b)
            {
                Input_C_D_S.Text = "F";
                Input_C_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("68");
            if (b)
            {
                RPM_D_S.Text = "F";
                RPM_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("default");
            if (b)
            {
                b = input.Contains("Immob");
                if (b)
                {
                    Immob_D_S.Text = "F";
                    Immob_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
                }
                b = input.Contains("OutputA");
                if (b)
                {
                    Output_D_S.Text = "F";
                    Output_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
                }
                b = input.Contains("Tag LED");
                if (b)
                {
                    Tag_LED_D_S.Text = "F";
                    Tag_LED_D_S.BackColor = System.Drawing.SystemColors.HotTrack;
                }

            }
            
        }

        private void CheckTrigerred(string input)
        {
            b = input.Contains("53");
            if (b)
            {
                IGN_D_T.Text = "F";
                IGN_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("54");
            if (b)
            {
                Panic_D_T.Text = "F";
                Panic_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("55");
            if (b)
            {
                Input_A_D_T.Text = "F";
                Input_A_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("56");
            if (b)
            {
                Input_B_D_T.Text = "F";
                Input_B_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("57");
            if (b)
            {
                Input_C_D_T.Text = "F";
                Input_C_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("58");
            if (b)
            {
                RPM_D_T.Text = "F";
                RPM_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
            }
            b = input.Contains("trigger");
            if (b)
            {
                b = input.Contains("Immob");
                if (b)
                {
                    Immob_D_T.Text = "F";
                    Immob_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
                }
                b = input.Contains("OutputA");
                if (b)
                {
                    Output_D_T.Text = "F";
                    Output_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
                }
                b = input.Contains("Tag LED");
                if (b)
                {
                    Tag_LED_D_T.Text = "F";
                    Tag_LED_D_T.BackColor = System.Drawing.SystemColors.HotTrack;
                }

            }
        }

        private void GetPorts()
        {

            //string[] ports = serialPort1.GetPortNames();
            comms.Items.Clear();
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames())
            {
                comms.Items.Add(port);
            }
            debug.Text += data;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //this.timer1.Start();
            //MessageBox.Show("BOX");
            if (!serialPort1.IsOpen)
            {
                try
                { 
                    serialPort1.Open();
                    debug.Text += "\r\nComms port opened\r\n";
                    Connect.Text = "Disconnect";
                }
                catch
                {
                    debug.Text += "\r\nComms port cant be opened\r\n";
                }
            }
            else
            {
                debug.Text = "\r\nCant port closed\r\n";
                serialPort1.Close();
                Connect.Text = "Connect";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            debug.Text += "HERE\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void comms_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comms.Text;
            serialPort1.BaudRate = 115200;
        }

        private void serialPort1_DataReceived_1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            SetText(data.ToString());
        }

        private void DebugClear_Click(object sender, EventArgs e)
        {
            debug.Text = String.Empty;
        }
    }
}
