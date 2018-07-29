using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace BF3_Main_Controller
{
    class serialHandle
    {
        private SerialPort _mySerial;



        serialHandle(SerialPort SData)
        {
            _mySerial = SData;
        }




    }
}
