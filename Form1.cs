using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;

namespace SerialCom
{
    public partial class Form1 : Form

    {
        private static readonly Stopwatch watch = new Stopwatch();
        bool isConnected = false;
        bool DirTimer = true;
        DateTime TimerHelper = new DateTime();
        String[] ports;
        SerialPort port;


        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();
            UpdateTime();

            foreach (string port in ports)
            {
                ComSel.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    ComSel.SelectedItem = ports[0];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = ComSel.GetItemText(ComSel.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            enableControls();
        }

        private void Led1CheckboxClicked(object sender, EventArgs e)

        {
            if (isConnected)
            {
                if (AlarmCtrl_02.Checked)
                {
                    port.Write("#LED1ON\n");
                    TimerDisp.Text = GetBioMetrics();
                }
                else
                {
                    port.Write("#LED1OF\n");
                }
            }
        }

        private void Led2CheckboxClicked(object sender, EventArgs e)

        {
            if (isConnected)
            {
                if (AlarmCtrl_01.Checked)
                {
                    port.Write("#LED2ON\n");
                    TimerDisp.Text = GetBioMetrics();
                }
                else
                {
                    port.Write("#LED2OF\n");
                }
            }
        }

        private void Led3CheckboxClicked(object sender, EventArgs e)

        {
            if (isConnected)
            {
                if (AlarmCtrl_03.Checked)
                {
                    port.Write("#LED3ON\n");
                    TimerDisp.Text = GetBioMetrics();
                }
                else
                {
                    port.Write("#LED3OF\n");
                }
            }
        }

        private string GetBioMetrics()
        {
            string a = port.ReadLine();
            return a;
        }

        private void HrtRt_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (HrtRt.Checked)
                {
                    GetHrtRt.Enabled = true;
                }
                else
                {
                    GetHrtRt.Enabled = false;
                }
            }
        }

        private void BdyTmp_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (BdyTmp.Checked)
                {
                    GetBdyTmp.Enabled = true;
                }
                else
                {
                    GetBdyTmp.Enabled = false;
                }
            }
        }

        private void GetHrtRt_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#SENDNUDES\n");
                label5.Text = GetBioMetrics();
                Thread.Sleep(200);
            }
        }

        private void GetBdyTmp_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Thread.Sleep(200);
            }
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime cust = TimeSet.Value;
            if ((cust.Hour > 0) || (cust.Minute > 0) || (cust.Second > 0))
            {
                DirTimer = false;
                string setter = string.Empty;
                setter = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                    cust.Hour,
                    cust.Minute,
                    cust.Second, "000");
                TimerDisp.Text = setter;
                TimerHelper = cust;
            }
        }

        private void enableControls()
        {
            AlarmCtrl_02.Enabled = true;
            AlarmCtrl_01.Enabled = true;
            AlarmCtrl_03.Enabled = true;
            AlCntrl.Enabled = true;

        }

        private void disableControls()
        {
            AlarmCtrl_02.Enabled = false;
            AlarmCtrl_01.Enabled = false;
            AlarmCtrl_03.Enabled = false;
            AlCntrl.Enabled = false;
        }

        private void resetDefaults()
        {
            AlarmCtrl_02.Checked = false;
            AlarmCtrl_01.Checked = false;
            AlarmCtrl_03.Checked = false;

        }

        private void UpdateTime()
        {
            if (DirTimer == true)
            {
                TimerDisp.Text = GetTimeString(watch.Elapsed);
            }
            else
            {
                TimeSpan elapsed = watch.Elapsed;
                DateTime cust = TimerHelper;
                if ((cust.Hour >= elapsed.Hours) && ((cust.Minute >= elapsed.Minutes) || (cust.Hour != 0)) && ((cust.Second >= elapsed.Seconds) || (cust.Hour != 0) && (cust.Minute != 0)))
                {
                    TimerDisp.Text = GetRevTimeString(watch.Elapsed, TimerHelper);
                }
                else
                {
                    DirTimer = true;
                    timer.Enabled = false;
                    watch.Stop();
                    watch.Reset();
                }

            }

        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string resultofconv = string.Empty;
            resultofconv = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                elapsed.Hours,
                elapsed.Minutes,
                elapsed.Seconds,
                elapsed.Milliseconds, "000");
            return resultofconv;
        }

        private string GetRevTimeString(TimeSpan elapsed, DateTime cust)
        {

            string resultofrevconv = string.Empty;
            if ((cust.Second - elapsed.Seconds) == 0)
            {
                var temp = new TimeSpan(0, 1, 0);
                TimerHelper.Subtract(temp);
            }
            if ((cust.Minute - elapsed.Minutes) == 0)
            {
                var temp = new TimeSpan(1, 0, 0);
                TimerHelper.Subtract(temp);
            }
            resultofrevconv = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                (cust.Hour - elapsed.Hours),
                ((cust.Minute < elapsed.Minutes) ? (60 + cust.Minute - elapsed.Minutes) : cust.Minute - elapsed.Minutes),
                ((cust.Second < elapsed.Seconds) ? (60 + cust.Second - elapsed.Seconds) : cust.Second - elapsed.Seconds),
                (999 - elapsed.Milliseconds));
            return resultofrevconv;
        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            if (stbtn.Text == "Start")
            {
                watch.Start();
                stbtn.Text = "Pause";
                timer.Enabled = true;
            }
            else
            {
                watch.Stop();
                stbtn.Text = "Start";
                timer.Enabled = false;
            }
        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            watch.Reset();
            timer.Enabled = false;
            UpdateTime();
            stbtn.Text = "Start";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getAvailableComPorts();
            foreach (string port in ports)
            {
                ComSel.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    ComSel.SelectedItem = ports[0];
                }
            }
        }

    }
}
