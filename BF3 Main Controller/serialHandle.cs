using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace BF3_Main_Controller
{
    public class serialHandle
    {
        private SerialPort mySerial;

        public EventHandler<TextArgs> updateFormEventHan;

        public serialHandle(SerialPort serial)
        {
            mySerial = serial;
        }

        public void handleEvent(object sender, TextArgs e)
        {
            MessageBox.Show("Message Received\n" + e.Message, "serialHandle");
            Console.WriteLine("SerialHandle: " + e.Message);
        }

        private void updateForm(string mes)
        {
            EventHandler<TextArgs> temp = updateFormEventHan;
            if (temp != null)
            {
                temp(null, new TextArgs(mes));
            }
        }

        public void test(string a)
        {
            updateForm(a);
        }

        //private byte CRC8(byte[] data, int len)
        //{
        //    byte crc = 0x00;
        //    int i = 0;

        //    while (i <= (len-1))
        //    {
        //        byte extract = data[i];
        //        for (byte tempI = 8; tempI > 0; tempI--)
        //        {
        //            byte sum = (byte)(((int)crc ^ (int)extract) & (int)0x01);
        //            sum >>= 1;
        //            if ((int)sum == 1)
        //            {
        //                crc ^= 0x8C;
        //            }
        //            extract >>= 1;
        //        }
        //        i++;
        //    }

        //    return crc;
        //}

        private string FormatData(byte data)
        {
            string result = "";

            //
            if((data >= 0x20) && (data <= 0x7E))
            {
                result = Convert.ToString(data);
            }
            else
            {
                result = "[" + Convert.ToString(Convert.ToInt16(data)) + "]";
            }

            return result;
        }

        private bool sendFrame(serialFrame frame)
        {
            bool result = true;
            byte[] data = new byte[8];
            byte[] sendData = new byte[9];
            string sendString = "";

            // require a byte array without the crc to use the crc function
            data[0] = frame.RecAddy;
            data[1] = frame.SendAddy;
            data[2] = frame.ModuleType;
            data[3] = frame.Command;
            data[4] = Convert.ToByte(frame.Data);
            data[5] = Convert.ToByte(frame.Data >> 8);
            data[6] = Convert.ToByte(frame.Data >> 16);
            data[7] = Convert.ToByte(frame.Data >> 24);

            sendData[0] = frame.RecAddy;
            sendData[1] = frame.SendAddy;
            sendData[2] = frame.ModuleType;
            sendData[3] = frame.Command;
            sendData[4] = data[4];
            sendData[5] = data[5];
            sendData[6] = data[6];
            sendData[7] = data[7];
            sendData[8] = Crc8.ComputeChecksum(data);


            Console.WriteLine("----------\nComputed data frame\nSend Addy [{0:X}]\nRec Addy [{1:X}]\nModule [{2:X}]\nCommand [{3:X}]\nData [{4:X},{5:X},{6:X},{7:X}]\nCRC [{8:X}]"
                        , sendData[0], sendData[1], sendData[2], sendData[3], sendData[4], sendData[5], sendData[6], sendData[7], sendData[8]);

            if(Crc8.ComputeChecksum(sendData) == 0) { Console.WriteLine("Checksum PASS"); }
            else { Console.WriteLine("Checksum FAIL"); }

            sendString = Encoding.ASCII.GetString(sendData);
            
            if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.WriteLine(sendString);
                    Console.WriteLine("sent Data Frame");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Failed to send serial frame\nSend Addy [{0:X}]\nRec Addy [{1:X}]\nModule [{2:X}]\nCommand [{3:X}]\nData [{4:X},{5:X},{6:X},{7:X}]\nCRC [{8:X}]\nException: " + ex.Message
                        ,  sendData[0], sendData[1], sendData[2], sendData[3], sendData[4], sendData[5], sendData[6], sendData[7], sendData[8] );
                }
            }
            else
            {
                result = false;
                Console.WriteLine("Cannot send data frame as Serial Port is closed");
            }

            return result;
        }

        public bool SendSerialFrame(serialFrame frame)
        {
            return sendFrame(frame);
        }

        public void test()
        {
            serialFrame myFrame = new serialFrame(15, 11, 11, 10, 0, 0);
            sendFrame(myFrame);
        }







    }
}
