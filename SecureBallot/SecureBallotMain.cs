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
    public partial class SecureBallotMain : Form
    {
        private static Ballot ballot;
        public SecureBallotMain()
        {
            InitializeComponent();
        }

        private void SecureBallotMain_Load(object sender, EventArgs e)
        {
            tb_no1.Text = getTextFromFile("Item1.txt");
            tb_no2.Text = getTextFromFile("Item2.txt");
            tb_no3.Text = getTextFromFile("Item3.txt");
            tb_no4.Text = getTextFromFile("Item4.txt");

            ballot = new Ballot(4);
        }

        private string getTextFromFile(string filename)
        {
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
            filePath += @"\" + filename;
            string text = File.ReadAllText(filePath);

            return text;
        }

        private void button_cast_vote_Click(object sender, EventArgs e)
        {
            if (ballot.isBallotFilled())
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(
                    "Are you sure you would like to cast your vote?\nThis action can not be undone.", 
                    "WARNING", buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    MessageBox.Show("Your vote has been cast!");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("You still have unselected options on your ballot:\n" +
                    ballot.getUncountedSelections());
            }
        }

        private void rb_no1_yes_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, Vote.Yes);
        }

        private void rb_no1_no_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, Vote.No);
        }

        private void rb_no2_yes_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, Vote.Yes);
        }

        private void rb_no2_no_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, Vote.No);
        }

        private void rb_no3_yes_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(3, Vote.Yes);
        }

        private void rb_no3_no_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(3, Vote.No);
        }

        private void rb_no4_yes_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(4, Vote.Yes);
        }

        private void rb_no4_no_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(4, Vote.No);
        }
    }
    public enum Vote
    {
        Yes, No, Uncounted
    }

    public class Ballot
    {
        private Dictionary<int, Vote> votes;

        public Ballot(int size)
        {
            votes = new Dictionary<int, Vote>();

            for (int i = 1; i <= size; ++i)
            {
                votes.Add(i, Vote.Uncounted);
            }
        }

        public void castVote(int num, Vote vote)
        {
            votes[num] = vote;
        }

        public bool isBallotFilled()
        {
            foreach (KeyValuePair<int, Vote> v in votes)
            {
                if (v.Value == Vote.Uncounted)
                    return false;
            }

            return true;
        }

        public string getUncountedSelections()
        {
            List<int> list = new List<int>();

            foreach (KeyValuePair<int, Vote> v in votes)
            {
                if (v.Value == Vote.Uncounted)
                    list.Add(v.Key);
            }

            StringBuilder sb = new StringBuilder();
            foreach (int curr in list)
            {
                sb.Append(String.Format("no{0}", curr));
                if (curr != list.Last())
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
