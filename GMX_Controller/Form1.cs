using System;
using System.Windows.Forms;


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
            OpenDMX.start();


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
            //// Close all forms except the main form (this form)
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form != this)
            //    {
            //        form.Close();
            //    }
            //}

            //// Terminate the application
            //Application.Exit();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           OpenDMX.close();
           Application.Exit();

        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the value to turn the confetti cannon on (DMX channel 1, value 11)
                OpenDMX.setDmxValue(1, 11);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while turning the confetti cannon on: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the value to turn the confetti cannon off (DMX channel 1, value 0)
                OpenDMX.setDmxValue(1, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while turning the confetti cannon off: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
