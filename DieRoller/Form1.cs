using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is DieRollControl)
                { 
                    (control as DieRollControl).LogMessage = LogText;
                }
            }
        }

        private void LogText(String txt)
        {
            this.richTextBox1.AppendText(txt);
        }
    }
}
