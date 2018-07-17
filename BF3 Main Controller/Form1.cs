using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.VisualBasic.FileIO;

namespace BF3_Main_Controller
{
    public partial class frmMainMenu : Form
    {
        private EventHandler<TextArgs> updateDisplayEventHan;

        private BindingSource myTagList = new BindingSource();
        private BindingSource myAddyList = new BindingSource();

        private SerialPort mySerial = new SerialPort();

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            updateDisplayEventHan += new EventHandler<TextArgs>(UpdateDebugDisplay);

            dgvRFID.DataSource = myTagList;
            dgvAddy.DataSource = myAddyList;
        }

        private void UpdateDebug(string mes)
        {
            EventHandler<TextArgs> temp = updateDisplayEventHan;
            if(temp != null)
            {
                temp(null, new TextArgs(mes));
            }
        }

        protected virtual void UpdateDebugDisplay(object sender, TextArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new EventHandler<TextArgs>(UpdateDebugDisplay), new object[] { sender, e});
            }
            else
            {
                rtbDebug.AppendText(e.Message + "\r\n");
                rtbDebug.ScrollToCaret();
            }
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

        private void CBCom_MouseDown(object sender, MouseEventArgs e)
        {
            if (!mySerial.IsOpen) { TestComPorts(); }
        }

        //------------------------------ Serial Port -------------------------------------

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
                    UpdateDebug("Serial Connected - " + CBCom.Items[CBCom.SelectedIndex].ToString() + " : " + mySerial.BaudRate + "\n");
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


        //-------------------------------- Testing ----------------------------------------

        private void ReadRFIDFile()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (TextFieldParser pas = new TextFieldParser(openFileDialog1.FileName))
                    {
                        pas.CommentTokens = new string[] { "#" };
                        pas.SetDelimiters(new string[] { "," });
                        pas.HasFieldsEnclosedInQuotes = true;

                        pas.ReadLine();
                        int i = 0;

                        while (!pas.EndOfData)
                        {
                            UpdateDebug("Read Line: " + i.ToString() + "\n");
                            string[] feilds = pas.ReadFields();
                            for (int j = 0; j < feilds.Length; j++)
                            {
                                UpdateDebug(feilds[j]);
                            }

                            //myTagList[i].ID = Convert.ToInt32(feilds[0]);
                            //myTagList[i].TagNum = Convert.ToInt32(feilds[1]);
                            //myTagList[i].Type = Convert.ToString(feilds[2]);
                            //myTagList[i].TypeUse = Convert.ToString(feilds[3]);
                            //myTagList[i].TagLabel = Convert.ToString(feilds[4]);
                            //myTagList[i].Team = Convert.ToString(feilds[5]);
                            //myTagList[i].InUse = Convert.ToBoolean(feilds[6]);
                            //feilds[6] = feilds[6].Replace("","0");
                            myTagList.Add(new RFIDTagList(Convert.ToInt32(feilds[0]), Convert.ToInt32(feilds[1]), Convert.ToString(feilds[2]),
                                Convert.ToString(feilds[3]), Convert.ToString(feilds[4]), Convert.ToString(feilds[5]),
                                Convert.ToBoolean(Convert.ToInt16(feilds[6]))));

                            UpdateDebug("\r\n");
                            i++;
                        }
                    }

                    //dgvRFID.DataSource = myTagList;
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, "CSV loading error"); }
            }
        }

        private void ReadAddyFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (TextFieldParser pas = new TextFieldParser(openFileDialog1.FileName))
                    {
                        pas.CommentTokens = new string[] { "#" };
                        pas.SetDelimiters(new string[] { "," });
                        pas.HasFieldsEnclosedInQuotes = true;

                        pas.ReadLine();
                        int i = 0;

                        while (!pas.EndOfData)
                        {
                            UpdateDebug("Read Line: " + i.ToString() + "\n");
                            string[] feilds = pas.ReadFields();
                            for (int j = 0; j < feilds.Length; j++)
                            {
                                UpdateDebug(feilds[j]);
                            }

                            //myTagList[i].ID = Convert.ToInt32(feilds[0]);
                            //myTagList[i].TagNum = Convert.ToInt32(feilds[1]);
                            //myTagList[i].Type = Convert.ToString(feilds[2]);
                            //myTagList[i].TypeUse = Convert.ToString(feilds[3]);
                            //myTagList[i].TagLabel = Convert.ToString(feilds[4]);
                            //myTagList[i].Team = Convert.ToString(feilds[5]);
                            //myTagList[i].InUse = Convert.ToBoolean(feilds[6]);
                            //feilds[6] = feilds[6].Replace("","0");
                            myAddyList.Add(new AddyList(Convert.ToInt32(feilds[0]), Convert.ToString(feilds[1]),
                                Convert.ToString(feilds[2]), Convert.ToBoolean(Convert.ToInt16(feilds[3])), Convert.ToString(feilds[4])));

                            UpdateDebug("\r\n");
                            i++;
                        }
                    }

                    //dgvRFID.DataSource = myTagList;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "CSV loading error"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDebug("trying RFID test");
            ReadRFIDFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDebug("trying Addy test");
            ReadAddyFile();
        }
    }
}
