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
    partial class frmMainMenu : Form
    {
        private EventHandler<TextArgs> updateDisplayEventHan;
        private EventHandler<TextArgs> updateSerHanEventHan;

        private BindingSource myTagList = new BindingSource();
        private BindingSource myAddyList = new BindingSource();

        private serialHandle mySerHan;
        private SerialPort mySerial = new SerialPort();

        public frmMainMenu(SerialPort serial)
        {
            InitializeComponent();
            mySerial = serial;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            updateDisplayEventHan += new EventHandler<TextArgs>(UpdateDebugDisplay);

            mySerHan = new serialHandle(mySerial);

            mySerHan.updateFormEventHan += new EventHandler<TextArgs>(UpdateDebugDisplay);
            updateSerHanEventHan += new EventHandler<TextArgs>(mySerHan.handleEvent);

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

        private void UpdateSerHan(string mes)
        {
            EventHandler<TextArgs> temp = updateSerHanEventHan;
            if (temp != null)
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

        //private void TestComPorts()
        //{
        //    if (!mySerial.IsOpen)
        //    {
        //        int prevBaud = mySerial.BaudRate;
        //        CBCom.Items.Clear();
        //        mySerial.BaudRate = 9600;
        //        mySerial.Parity = System.IO.Ports.Parity.None;
        //        mySerial.StopBits = System.IO.Ports.StopBits.One;
        //        mySerial.DtrEnable = true;
        //        mySerial.RtsEnable = true;
        //        mySerial.ReceivedBytesThreshold = 2;
        //        mySerial.ReadTimeout = 2000;
        //        //serialPort.NewLine = "\n";

        //        for (int i = 0; i < 30; i++)
        //        {
        //            string s = "COM" + Convert.ToString(i);
        //            mySerial.PortName = s;

        //            if (!mySerial.IsOpen)
        //            {
        //                try
        //                {
        //                    mySerial.Open();
        //                    CBCom.Items.Add(s);
        //                    mySerial.Close();
        //                }
        //                catch
        //                {
        //                    //Serial port is not accessable
        //                }
        //            }
        //        }

        //        mySerial.BaudRate = prevBaud;
        //    }
        //}

        //private void CBCom_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (!mySerial.IsOpen) { TestComPorts(); }
        //}

        ////------------------------------ Serial Port -------------------------------------

        //private void btnComConnect_Click(object sender, EventArgs e)
        //{
        //    if (!mySerial.IsOpen)
        //    {
        //        //Try to open the serial port
        //        try
        //        {
        //            //serialPort.PortName = CBCom.Items[CBCom.SelectedIndex].ToString();
        //            mySerial.PortName = CBCom.Text;
        //            mySerial.BaudRate = Convert.ToInt32(CBBaud.Text);
        //            mySerial.DataBits = Convert.ToInt32(CBDataBits.Text);
        //            mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBStopBits.Text);
        //            mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), CBPairity.Text);
        //            mySerial.DtrEnable = ChBxDTR.Checked;
        //            mySerial.RtsEnable = ChBxRTS.Checked;
        //            mySerial.ReceivedBytesThreshold = 5;
        //            mySerial.ReadTimeout = 2000;
        //            mySerial.WriteTimeout = 1000;

        //            mySerial.Open();
        //            mySerial.ReadExisting();
        //            btnComConnect.Text = "Disconnect";
        //            btnComConnect.BackColor = Color.SpringGreen;
        //            //SerialToolStripLabel.Text = "Serial Status: Connected ; " + CBCom.Items[CBCom.SelectedIndex].ToString() +
        //            //    ", " + serialPort.BaudRate +
        //            //    ", " + serialPort.DataBits +
        //            //    ", " + serialPort.StopBits +
        //            //    ", " + serialPort.Parity;
        //            UpdateDebug("Serial Connected - " + CBCom.Items[CBCom.SelectedIndex].ToString() + " : " + mySerial.BaudRate + "\n");
        //            grBCom.Enabled = false;
        //        }
        //        catch (UnauthorizedAccessException SerialException)
        //        {
        //            MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (System.IO.IOException SerialException)
        //        {
        //            MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            mySerial.Close();
        //        }
        //        catch (InvalidOperationException SerialException)
        //        {
        //            MessageBox.Show(SerialException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            mySerial.Close();
        //        }
        //        catch (Exception xxx)
        //        {
        //            MessageBox.Show("Unkonown Error\n" + xxx.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            mySerial.Close();
        //        }
        //    }
        //    else
        //    {
        //        mySerial.Close();
        //        btnComConnect.Text = "Connect";
        //        btnComConnect.BackColor = Color.LightCoral;
        //        grBCom.Enabled = true;
        //    }
        //}


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
                            Console.WriteLine("Read Line: " + i.ToString() + "\n");
                            string[] feilds = pas.ReadFields();
                            for (int j = 0; j < feilds.Length; j++)
                            {
                                Console.WriteLine(feilds[j]);
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
                                //Convert.ToBoolean(Convert.ToInt16(feilds[6]))));
                                Convert.ToBoolean(feilds[6])));

                            Console.WriteLine("\r\n");
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
                            Console.WriteLine("Read Line: " + i.ToString() + "\n");
                            string[] feilds = pas.ReadFields();
                            for (int j = 0; j < feilds.Length; j++)
                            {
                                Console.WriteLine(feilds[j]);
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
                                //Convert.ToString(feilds[2]), Convert.ToBoolean(Convert.ToInt16(feilds[3])), Convert.ToString(feilds[4])));
                                Convert.ToString(feilds[2]), Convert.ToBoolean(feilds[3]), Convert.ToString(feilds[4])));

                            Console.WriteLine("\r\n");
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
            Console.WriteLine("trying RFID test");
            ReadRFIDFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("trying Addy test");
            ReadAddyFile();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = this.Size.Height.ToString();
            label9.Text = this.Size.Width.ToString();
            Console.WriteLine("TEST");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExtractDataToCSV(dgvRFID);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExtractDataToCSV(dgvAddy);
        }

        private void ExtractDataToCSV(DataGridView dgv)
        {

            // Don't save if no data is returned
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                columnsHeader += dgv.Columns[i].Name + ",";
            }
            columnsHeader = columnsHeader.Replace("DataGridViewTextBoxColumn", "");
            columnsHeader = columnsHeader.Replace("DataGridViewCheckBoxColumn", "");
            Console.WriteLine(columnsHeader);
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                    // Confirm to the user it has been completed.
                    MessageBox.Show("CSV file saved.");
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mySerHan.test("This is a test");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateSerHan("Huzza i can talk");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(mySerial.IsOpen)
            {
                mySerial.WriteLine("TEST");
                Console.WriteLine("Written \"TEST\" to serial port " + mySerial.PortName);
            }
            else
            {
                Console.WriteLine("Serial Port is closed");
            }
        }
    }
}
