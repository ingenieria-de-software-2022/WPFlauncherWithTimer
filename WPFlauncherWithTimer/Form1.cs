using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFlauncherWithTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayedTime.Text = DateTime.Now.ToString("hh:mm:ss:f-dd/MM/yyyy");

            if (displayedTime.Text == textBoxTime.Text)
            {
                if (circuit.Checked)
                {
                    System.Diagnostics.Process.Start("WFcircuito.exe");
                }
                
                if (graphic.Checked)
                {
                    System.Diagnostics.Process.Start("WFgraficador.exe");
                }
                
                if (alarm.Checked)
                {
                    System.Diagnostics.Process.Start("WPFalarmaWF.exe");
                }
            }
        }
    }
}
