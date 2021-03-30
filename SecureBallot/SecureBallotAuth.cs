using System;
using System.IO;
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
    public partial class SecureBallotAuth : Form
    {
        private bool photo_submitted;
        private bool dob_submitted;

        public SecureBallotAuth()
        {
            InitializeComponent();
        }

        private void SecureBallotAuth_Load(object sender, EventArgs e)
        {
            tb_terms.Text = getTOS();
            label_vpn_info.Text = getVPNInfo();
            button_submit.Enabled = false;
            cb_tos_agreement.Enabled = false;
            photo_submitted = false;
            dob_submitted = false;
        }

        // Checks if all fields have been filled before allowing user to click
        private void allowClick()
        {
            if (tb_firstName.Text != "" && tb_lastName.Text != "" &&
                dob_submitted && photo_submitted)
            {
                cb_tos_agreement.Enabled = true;
            }
        }

        // Fills VPN info box
        private string getVPNInfo()
        {
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
            filePath += @"\SecureBallotVPNInfo.txt";
            string text = File.ReadAllText(filePath);

            return text;
        }

        // Fills TOS box
        private string getTOS()
        {
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
            filePath += @"\SecureBallotTermsandConditions.txt";
            string text = File.ReadAllText(filePath);

            return text;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            tb_photo_id.Text = "photoID.jpg";
            photo_submitted = true;

            allowClick();
        }

        private void cb_tos_agreement_CheckedChanged(object sender, EventArgs e)
        {
            button_submit.Enabled = cb_tos_agreement.Checked;
        }

        private void dtp_DOB_ValueChanged(object sender, EventArgs e)
        {
            dob_submitted = true;

            allowClick();
        }

        private void tb_lastName_TextChanged(object sender, EventArgs e)
        {
            allowClick();
        }

        private void tb_firstName_TextChanged(object sender, EventArgs e)
        {
            allowClick();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecureBallotVerification secureBallot = new SecureBallotVerification();
            secureBallot.Show();
        }
    }
}
