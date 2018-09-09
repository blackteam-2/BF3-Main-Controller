using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BF3_Main_Controller
{
    public partial class Test_Class : Form
    {
        frmMainMenu myForm = new frmMainMenu();

        public Test_Class()
        {
            Thread myFormThread = new Thread(new ThreadStart(startGUI));
            myFormThread.Start();
            //this.Hide();
        }

        private void startGUI()
        {
            myForm.Show();
            while (true) { }
        }

    }
}
