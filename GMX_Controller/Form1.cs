using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GMX_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Register hotkeys when the form is initialized
            RegisterHotKey(Handle, HOTKEY_ID_ON, MOD_ALT, (int)Keys.O);
            RegisterHotKey(Handle, HOTKEY_ID_OFF, MOD_ALT, (int)Keys.L);
            InitializeComponent();
        }

        // Import the RegisterHotKey and UnregisterHotKey functions from the user32.dll library
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Define constants for modifier keys
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;

        // Define a constant for the WM_HOTKEY message
        private const int WM_HOTKEY = 0x0312;

        // Define hotkey IDs
        private const int HOTKEY_ID_ON = 1;
        private const int HOTKEY_ID_OFF = 2;


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Handle WM_HOTKEY messages
            if (m.Msg == WM_HOTKEY)
            {
                // Check which hotkey was pressed and perform the corresponding action
                switch (m.WParam.ToInt32())
                {
                    case HOTKEY_ID_ON:
                        BtnOn_Click(null, EventArgs.Empty);
                        break;
                    case HOTKEY_ID_OFF:
                        BtnOff_Click(null, EventArgs.Empty);
                        break;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Unregister hotkeys when the form is closing
            UnregisterHotKey(Handle, HOTKEY_ID_ON);
            UnregisterHotKey(Handle, HOTKEY_ID_OFF);

            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OpenDmxController.OpenConnection();

                if (OpenDMX.IsDeviceConnected())
                {
                    LblDetectDevice.Text = "DMX Device Detected";
                }
                else
                {
                    LblDetectDevice.Text = "No DMX Device Detected";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while initializing the DMX connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                OpenDmxController.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while closing the DMX connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDmxController.CloseConnection();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exiting the application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the value to activate the confetti cannon (fan) (Control channel 1, value 255)
                OpenDmxController.SetDmxValues(new byte[] { 255 });
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
                OpenDmxController.SetDmxValues(new byte[] { 0 });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while turning the confetti cannon off: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.O)
            {
                // Call the BtnOn_Click event handler to perform the same action as clicking the "On" button
                BtnOn_Click(sender, e);
            }
            else if (e.Alt && e.KeyCode == Keys.L)
            {
                BtnOff_Click(sender, e);
            }
        }
       

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void Big_Mama_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Show the form when the user clicks on the notification icon
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
