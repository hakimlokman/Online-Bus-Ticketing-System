using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void busTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusType fbt = new frmBusType();
            fbt.Show();
            fbt.MdiParent = this;
        }

        private void entryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuses fb = new frmBuses();
            fb.Show();
            fb.MdiParent = this;
        }

        private void entryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRoute fr = new frmRoute();
            fr.Show();
            fr.MdiParent = this;
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking fbk = new frmBooking();
            fbk.Show();
            fbk.MdiParent = this;
        }

        private void entryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSeat fs = new frmSeat();
            fs.Show();
            fs.MdiParent = this;
        }

        private void addNewSuperViserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSuperVisor fsv = new frmSuperVisor();
            fsv.Show();
            fsv.MdiParent = this;
        }

        private void addNewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeriver fd = new frmDeriver();
            fd.Show();
            fd.MdiParent = this;

        }

        private void updateDeleteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDriverUpdateDelete fd = new frmDriverUpdateDelete();
            fd.Show();
            fd.MdiParent = this;
        }

        private void updateDeleteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmSupUpdateDelete fd = new frmSupUpdateDelete();
            fd.Show();
            fd.MdiParent = this;
        }
    }
}
