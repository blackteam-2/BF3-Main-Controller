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
