using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MapDriveUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            // Variables for batch file arguments
            string Argument_1;
            string Argument_2;

            // Argument 1 is for drive letter, Argument 2 is for 
            // transmitting computer name
            Argument_2 = txtTransmit.Text;
            Argument_1 = txtDrive.Text;

            // Creates a new process called thisProcess
            Process thisProcess = new Process();
            thisProcess.StartInfo.CreateNoWindow = false;
            thisProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            // If the persistent mapping option is checked, execute the batch file
            // for persistent mapping
            if (chkPers.Checked == true)
                thisProcess.StartInfo.FileName = @"C:\PTH\map_drive_per.bat";
                thisProcess.StartInfo.Arguments = string.Format("{0} {1}", Argument_1, Argument_2);
            // If the persistent mapping option is not checked, execute the batch file
            // for regular mapping
            if (chkPers.Checked == false)
                thisProcess.StartInfo.FileName = @"C:\PTH\map_drive.bat";
                thisProcess.StartInfo.Arguments = string.Format("{0} {1}", Argument_1, Argument_2);
            // Start thisProcess
                thisProcess.Start();
            // Wait for thisProcess to complete
                thisProcess.WaitForExit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
