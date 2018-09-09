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











    }
}
