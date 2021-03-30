
namespace SecureBallot
{
    partial class SecureBallotAuth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_terms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tos_agreement = new System.Windows.Forms.CheckBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.button_browse = new System.Windows.Forms.Button();
            this.tb_photo_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_vpn_info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_terms
            // 
            this.tb_terms.Location = new System.Drawing.Point(405, 66);
            this.tb_terms.Multiline = true;
            this.tb_terms.Name = "tb_terms";
            this.tb_terms.ReadOnly = true;
            this.tb_terms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_terms.Size = new System.Drawing.Size(383, 250);
            this.tb_terms.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(775, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Getting Started with SecureBallot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_tos_agreement
            // 
            this.cb_tos_agreement.AutoSize = true;
            this.cb_tos_agreement.Location = new System.Drawing.Point(22, 338);
            this.cb_tos_agreement.Name = "cb_tos_agreement";
            this.cb_tos_agreement.Size = new System.Drawing.Size(651, 21);
            this.cb_tos_agreement.TabIndex = 2;
            this.cb_tos_agreement.Text = "I agree to the Terms and Conditions and confirm the identity entered above is min" +
    "e and up to date.";
            this.cb_tos_agreement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_tos_agreement.UseVisualStyleBackColor = true;
            this.cb_tos_agreement.CheckedChanged += new System.EventHandler(this.cb_tos_agreement_CheckedChanged);
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(99, 36);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(272, 22);
            this.tb_firstName.TabIndex = 3;
            this.tb_firstName.TextChanged += new System.EventHandler(this.tb_firstName_TextChanged);
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(99, 64);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(272, 22);
            this.tb_lastName.TabIndex = 4;
            this.tb_lastName.TextChanged += new System.EventHandler(this.tb_lastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(679, 334);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(109, 27);
            this.button_submit.TabIndex = 7;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date of Birth";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.AllowDrop = true;
            this.dtp_DOB.Location = new System.Drawing.Point(99, 93);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(272, 22);
            this.dtp_DOB.TabIndex = 9;
            this.dtp_DOB.Value = new System.DateTime(2021, 3, 29, 0, 0, 0, 0);
            this.dtp_DOB.ValueChanged += new System.EventHandler(this.dtp_DOB_ValueChanged);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(283, 121);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(88, 25);
            this.button_browse.TabIndex = 10;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // tb_photo_id
            // 
            this.tb_photo_id.Location = new System.Drawing.Point(99, 122);
            this.tb_photo_id.Name = "tb_photo_id";
            this.tb_photo_id.ReadOnly = true;
            this.tb_photo_id.Size = new System.Drawing.Size(178, 22);
            this.tb_photo_id.TabIndex = 11;
            this.tb_photo_id.Text = "No file uploaded";
            this.tb_photo_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Photo ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_vpn_info);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_firstName);
            this.groupBox1.Controls.Add(this.tb_photo_id);
            this.groupBox1.Controls.Add(this.tb_lastName);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_DOB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 250);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Enter Your Information Below";
            // 
            // label_vpn_info
            // 
            this.label_vpn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vpn_info.Location = new System.Drawing.Point(6, 157);
            this.label_vpn_info.Name = "label_vpn_info";
            this.label_vpn_info.Size = new System.Drawing.Size(365, 82);
            this.label_vpn_info.TabIndex = 13;
            this.label_vpn_info.Text = "label6";
            this.label_vpn_info.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SecureBallotAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.cb_tos_agreement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_terms);
            this.Name = "SecureBallotAuth";
            this.Text = "SecureBallot Authorization";
            this.Load += new System.EventHandler(this.SecureBallotAuth_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_terms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_tos_agreement;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox tb_photo_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_vpn_info;
    }
}

