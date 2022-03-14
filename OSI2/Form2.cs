using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace OSI2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Process[] procList = Process.GetProcesses();

            foreach (Process p in procList)
            {
                MessageBox.Show(p.ProcessName + " 0");
            }
        }
    }
}
