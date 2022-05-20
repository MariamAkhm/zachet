using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachet
{
    public partial class alarms : Form
    {
        public alarms()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            newAlarm a = new newAlarm();
            a.Show();
        }
    }
}
