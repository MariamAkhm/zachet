using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace zachet
{
    public partial class newAlarm : Form
    {
        public newAlarm()
        {
            InitializeComponent();
        }
        Timer timer01 = new Timer();
        SoundPlayer sp = new SoundPlayer("F:\\1.wav");
        bool b = false;

        private void delete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newAlarm_Load(object sender, EventArgs e)
        {
            delete.Enabled = false;
            timer01.Interval = 1000;
            timer01.Start();
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
