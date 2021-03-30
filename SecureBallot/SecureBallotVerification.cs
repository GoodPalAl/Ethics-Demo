using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureBallot
{
    public partial class SecureBallotVerification : Form
    {
        public SecureBallotVerification()
        {
            InitializeComponent();
        }

        private void SecureBallotVerification_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;

            timer1.Enabled = true;
            timer1.Interval = 500; // .5 seconds per tick
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Enabled = false;

                MessageBox.Show("Your Identity has been verified! Please close this window to continue.");

                this.Hide();
                SecureBallotMain secureBallot = new SecureBallotMain();
                secureBallot.Show();
            }
        }
    }
}
