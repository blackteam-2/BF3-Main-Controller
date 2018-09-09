using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace BF3_Main_Controller
{
    public partial class MainClass : Form
    {
        frmMainMenu myForm;
        SerialPort mySerial = new SerialPort();

        public MainClass()
        {
            InitializeComponent();
        }

        private void MainClass_Load(object sender, EventArgs e)
        {
            myForm = new frmMainMenu(mySerial);
            myForm.Show();
        }

        //------------------------------- Test Serial -------------------------------------

        private void TestComPorts()
        {
            if (!mySerial.IsOpen)
            {
                int prevBaud = mySerial.BaudRate;
                CBCom.Items.Clear();
                mySerial.BaudRate = 9600;
                mySerial.Parity = System.IO.Ports.Parity.None;
                mySerial.StopBits = System.IO.Ports.StopBits.One;
                mySerial.DtrEnable = true;
                mySerial.RtsEnable = true;
                mySerial.ReceivedBytesThreshold = 2;
                mySerial.ReadTimeout = 2000;
                //serialPort.NewLine = "\n";

                for (int i = 0; i < 30; i++)
                {
                    string s = "COM" + Convert.ToString(i);
                    mySerial.PortName = s;

                    if (!mySerial.IsOpen)
                    {
                        try
                        {
                            mySerial.Open();
                            CBCom.Items.Add(s);
                            mySerial.Close();
                        }
                        catch
                        {
                            //Serial port is not accessable
                        }
                    }
                }

                mySerial.BaudRate = prevBaud;
            }
        }

        //---------------------------------- Serial ----------------------------------------

        private void btnComConnect_Click(object sender, EventArgs e)
        {
            if (!mySerial.IsOpen)
            {
                //Try to open the serial port
                try
                {
                    //serialPort.PortName = CBCom.Items[CBCom.SelectedIndex].ToString();
                    mySerial.PortName = CBCom.Text;
                    mySerial.BaudRate = Convert.ToInt32(CBBaud.Text);
                    mySerial.DataBits = Convert.ToInt32(CBDataBits.Text);
                    mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBStopBits.Text);
                    mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), CBPairity.Text);
                    mySerial.DtrEnable = ChBxDTR.Checked;
                    mySerial.RtsEnable = ChBxRTS.Checked;
                    mySerial.ReceivedBytesThreshold = 5;
                    mySerial.ReadTimeout = 2000;
                    mySerial.WriteTimeout = 1000;

                    mySerial.Open();
                    mySerial.ReadExisting();
                    btnComConnect.Text = "Disconnect";
                    btnComConnect.BackColor = Color.SpringGreen;
                    //SerialToolStripLabel.Text = "Serial Status: Connected ; " + CBCom.Items[CBCom.SelectedIndex].ToString() +
                    //    ", " + serialPort.BaudRate +
                    //    ", " + serialPort.DataBits +
                    //    ", " + serialPort.StopBits +
                    //    ", " + serialPort.Parity;
                    //UpdateDebug("Serial Connected - " + CBCom.Items[CBCom.SelectedIndex].ToString() + " : " + mySerial.BaudRate + "\n");
                    Console.WriteLine("Serial Connected - " + CBCom.Items[CBCom.SelectedIndex].ToString() + " : " + mySerial.BaudRate + "\n");
                    grBCom.Enabled = false;
                }
                catch (UnauthorizedAccessException SerialException)
                {
                    MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.IOException SerialException)
                {
                    MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySerial.Close();
                }
                catch (InvalidOperationException SerialException)
                {
                    MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySerial.Close();
                }
                catch (Exception xxx)
                {
                    MessageBox.Show("Unkonown Error\n" + xxx.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySerial.Close();
                }
            }
            else
            {
                mySerial.Close();
                btnComConnect.Text = "Connect";
                btnComConnect.BackColor = Color.LightCoral;
                grBCom.Enabled = true;
            }
        }

        private void CBCom_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mySerial.IsOpen) { TestComPorts(); }
        }

        private void MainClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(mySerial.IsOpen)
            {
                mySerial.Close();
            }
        }


















    }
}
