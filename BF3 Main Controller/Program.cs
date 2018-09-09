using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BF3_Main_Controller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainClass());
            //Application.Run(new frmMainMenu());
        }
    }

    public class RFIDTagList
    {
        private int _ID;
        private int _TagNum;
        private string _Type;
        private string _typeUse;
        private string _TagLabel;
        private string _Team;
        private bool _InUse;

        public RFIDTagList(int id, int tnum, string type, string tuse, string label, string team, bool use)
        {
            _ID = id;
            _TagNum = tnum;
            _Type = type;
            _typeUse = tuse;
            _TagLabel = label;
            _Team = team;
            _InUse = use;
        }

        public int ID { get => _ID; set => _ID = value; }
        public int TagNum { get => _TagNum; set => _TagNum = value; }
        public string Type { get => _Type; set => _Type = value; }
        public string TagLabel { get => _TagLabel; set => _TagLabel = value; }
        public string TypeUse { get => _typeUse; set => _typeUse = value; }
        public string Team { get => _Team; set => _Team = value; }
        public bool InUse { get => _InUse; set => _InUse = value; }
    }

    public class AddyList
    {
        private int _addy;
        private string _type;
        private string _team;
        private bool _inUse;
        private string _name;

        public AddyList(int addy, string type, string team, bool use, string name)
        {
            _addy = addy;
            _type = type;
            _team = team;
            _inUse = use;
            _name = name;
        }

        public int Addy { get => _addy; set => _addy = value; }
        public string Type { get => _type; set => _type = value; }
        public string Team { get => _team; set => _team = value; }
        public bool InUse { get => _inUse; set => _inUse = value; }
        public string Name { get => _name; set => _name = value; }
    }

    public class serialFrame
    {
        private byte _RecAddy;
        private byte _SendAddy;
        private byte _ModuleType;
        private byte _Command;
        private UInt32 _Data;
        private byte _CRC;

        public byte RecAddy { get => _RecAddy; set => _RecAddy = value; }
        public byte SendAddy { get => _SendAddy; set => _SendAddy = value; }
        public byte ModuleType { get => _ModuleType; set => _ModuleType = value; }
        public byte Command { get => _Command; set => _Command = value; }
        public uint Data { get => _Data; set => _Data = value; }
        public byte CRC { get => _CRC; set => _CRC = value; }

        public serialFrame(byte recAddy, byte sendAddy, byte moduleType, byte command, UInt32 data, byte crc)
        {
            _RecAddy = recAddy;
            _SendAddy = sendAddy;
            _ModuleType = moduleType;
            _Command = command;
            _Data = data;
            _CRC = crc;
        }
    }

    //public static class Crc8
    //{
    //    static byte[] table = new byte[256];
    //    // x8 + x7 + x6 + x4 + x2 + 1
    //    const byte poly = 0xd5;

    //    public static byte ComputeChecksum(params byte[] bytes)
    //    {
    //        byte crc = 0;
    //        if (bytes != null && bytes.Length > 0)
    //        {
    //            foreach (byte b in bytes)
    //            {
    //                crc = table[crc ^ b];
    //            }
    //        }
    //        return crc;
    //    }

    //    static Crc8()
    //    {
    //        for (int i = 0; i < 256; ++i)
    //        {
    //            int temp = i;
    //            for (int j = 0; j < 8; ++j)
    //            {
    //                if ((temp & 0x80) != 0)
    //                {
    //                    temp = (temp << 1) ^ poly;
    //                }
    //                else
    //                {
    //                    temp <<= 1;
    //                }
    //            }
    //            table[i] = (byte)temp;
    //        }
    //    }
    //}

    public class TextArgs : EventArgs
    {
        private string _Message;

        public TextArgs(string mess)
        {
            _Message = mess;
        }

        public string Message { get => _Message; set => _Message = value; }
    }
}
