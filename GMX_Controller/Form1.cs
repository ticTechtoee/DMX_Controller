using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMX_Controller;


namespace GMX_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //OpenDMX.start();
            if (OpenDMX.IsDeviceConnected())
            {
                LblDetectDevice.Text = "DMX Device Detected";
            }
            else
            {
                LblDetectDevice.Text = "No DMX Device Detected";

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
