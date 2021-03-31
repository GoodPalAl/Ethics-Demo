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
        private static List<RadioButton> radioButtons;
        public SecureBallotMain()
        {
            InitializeComponent();
        }

        private void SecureBallotMain_Load(object sender, EventArgs e)
        {
            tb_ref_ques.Text = getTextFromFile("ItemRefQues.txt");

            ballot = new Ballot(3);
            radioButtons = new List<RadioButton>();
            radioButtons.Add(rb_mayor1);
            radioButtons.Add(rb_mayor2);
            radioButtons.Add(rb_mayor3);
            radioButtons.Add(rb_mayor4);
            radioButtons.Add(rb_cm1);
            radioButtons.Add(rb_cm2);
            radioButtons.Add(rb_cm3);
            radioButtons.Add(rb_cm4);
            radioButtons.Add(rb_rq_yes);
            radioButtons.Add(rb_rq_no);
        }

        private string getTextFromFile(string filename)
        {
            string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
            filePath += @"\" + filename;
            string text = File.ReadAllText(filePath);

            return text;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            foreach (RadioButton SelectedButton in radioButtons)
                SelectedButton.Checked = false;

            ballot.Clear();
        }

        private void button_cast_vote_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            if (!ballot.isBallotFilled())
            {
                message.Append("YOU HAVE UNSELECTED OPTIONS ON YOUR BALLOT!\n");
            }
            message.Append("Are you sure you would like to cast your vote?\nThis action can not be undone.");

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message.ToString(), "WARNING", buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show("Your vote has been cast!\nTo track your ballot's verification process, visit https://www.tampa.gov.");
                Application.Exit();
            }
        }

        private void rb_mayor1_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, new Candidate(1));
        }

        private void rb_mayor2_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, new Candidate(2));
        }

        private void rb_mayor3_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, new Candidate(3));
        }

        private void rb_mayor4_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(1, new Candidate(4));
        }

        private void rb_cm1_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, new Candidate(1));
        }

        private void rb_cm2_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, new Candidate(2));
        }

        private void rb_cm3_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, new Candidate(3));
        }

        private void rb_cm4_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(2, new Candidate(4));
        }

        private void rb_rq_yes_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(3, new YesNo(true));
        }

        private void rb_rq_no_CheckedChanged(object sender, EventArgs e)
        {
            ballot.castVote(3, new YesNo(false));
        }
    }
    public class Vote
    {
        protected bool counted;
        public Vote()
        {
            counted = false;
        }
        public bool Counted()
        {
            return counted;
        }
    }
    public class YesNo : Vote
    {
        private bool vote;

        public YesNo(bool vote)
        {
            this.vote = vote;
            counted = true;
        }
    }
    public class Candidate : Vote
    {
        private int can_num;

        public Candidate(int candidate)
        {
            can_num = candidate;
            counted = true;
        }
    }

    public class Ballot
    {
        private Dictionary<int, Vote> votes;

        public Ballot(int size)
        {
            votes = new Dictionary<int, Vote>();

            for (int i = 1; i <= size; ++i)
            {
                votes.Add(i, new Vote());
            }
        }

        public void Clear()
        {
            for (int i = 1; i <= votes.Count; ++i)
            {
                votes[i] = new Vote();
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
                if (!v.Value.Counted())
                    return false;
            }

            return true;
        }
    }
}
