using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GMX_Controller
{
    public class OpenDmxController
    {
        // Declare the functions from the OpenDmx.dll
        [DllImport("OpenDmx.dll")]
        public static extern int OpenDmx();

        [DllImport("OpenDmx.dll")]
        public static extern int CloseDmx();

        [DllImport("OpenDmx.dll")]
        public static extern int SetStartCode(int startCode);

        [DllImport("OpenDmx.dll")]
        public static extern int SetDmxRate(int dmxRate);

        [DllImport("OpenDmx.dll")]
        public static extern int UpdateDmx(IntPtr dmxArrayPointer);

        public static void OpenConnection()
        {
            // Call OpenDmx to initialize and open the DMX connection
            int result = OpenDmx();
            if (result == 0)
            {
                throw new Exception("Failed to open DMX connection.");
            }
        }

        public static void CloseConnection()
        {
            // Call CloseDmx to close the DMX connection
            CloseDmx();
        }

        public static void SetDmxValues(byte[] dmxValues)
        {
            // Allocate memory for the DMX array
            IntPtr dmxArrayPointer = Marshal.AllocHGlobal(dmxValues.Length);

            // Copy the DMX values to the allocated memory
            Marshal.Copy(dmxValues, 0, dmxArrayPointer, dmxValues.Length);

            // Call UpdateDmx to send the DMX values to the confetti cannon
            int result = UpdateDmx(dmxArrayPointer);

            // Free the allocated memory
            Marshal.FreeHGlobal(dmxArrayPointer);

            if (result == 0)
            {
                throw new Exception("Failed to update DMX values.");
            }
        }
    }
}
