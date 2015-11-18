using System;

namespace _523116184522448
{
    partial class FormDanielFeature
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
            this.listBoxRepetitionPattern = new System.Windows.Forms.ListBox();
            this.listBoxIntervals = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelEventImages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRepetitions = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.radioButtonPublic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxGuestInvitationPrivelage = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRepetitionPattern
            // 
            //foreach (eEventRepetitionPattern RepeetitionPattern in Enum.GetValues(typeof(eEventRepetitionPattern)))
            //{
            //    this.listBoxRepetitionPattern.Add(RepeetitionPattern.ToString());
            //    this.listBoxRepetitionPattern.Items.Add
            //}
            this.listBoxRepetitionPattern.DataSource = Enum.GetNames(typeof(eEventRepetitionPattern));
            Console.WriteLine("Type is: {0}",
                Enum.GetNames(typeof(eEventRepetitionPattern)));
            this.listBoxRepetitionPattern.FormattingEnabled = true;
            this.listBoxRepetitionPattern.Location = new System.Drawing.Point(25, 41);
            this.listBoxRepetitionPattern.Name = "listBoxRepetitionPattern";
            this.listBoxRepetitionPattern.Size = new System.Drawing.Size(67, 56);
            this.listBoxRepetitionPattern.TabIndex = 0;
            this.listBoxRepetitionPattern.SelectedIndexChanged += new System.EventHandler(this.listBoxRepetitionPattern_SelectedIndexChanged);
            // 
            // listBoxIntervals
            // 
            this.listBoxIntervals.FormattingEnabled = true;
            this.listBoxIntervals.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.listBoxIntervals.Location = new System.Drawing.Point(116, 41);
            this.listBoxIntervals.Name = "listBoxIntervals";
            this.listBoxIntervals.Size = new System.Drawing.Size(44, 56);
            this.listBoxIntervals.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(366, 41);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // labelEventImages
            // 
            this.labelEventImages.AutoSize = true;
            this.labelEventImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEventImages.Location = new System.Drawing.Point(363, 20);
            this.labelEventImages.Name = "labelEventImages";
            this.labelEventImages.Size = new System.Drawing.Size(69, 13);
            this.labelEventImages.TabIndex = 4;
            this.labelEventImages.Text = "Starting from:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(113, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Intervals:\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event repeats:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(182, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of repetitions:\r\n";
            // 
            // listBoxRepetitions
            // 
            this.listBoxRepetitions.FormattingEnabled = true;
            this.listBoxRepetitions.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.listBoxRepetitions.Location = new System.Drawing.Point(185, 41);
            this.listBoxRepetitions.Name = "listBoxRepetitions";
            this.listBoxRepetitions.Size = new System.Drawing.Size(44, 56);
            this.listBoxRepetitions.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(292, 151);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(274, 154);
            this.textBoxDescription.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(289, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event description:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Event title:\r\n";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(25, 151);
            this.textBoxTitle.MaxLength = 256;
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(236, 24);
            this.textBoxTitle.TabIndex = 11;
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPrivate.TabIndex = 13;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPublic
            // 
            this.radioButtonPublic.AutoSize = true;
            this.radioButtonPublic.Location = new System.Drawing.Point(147, 19);
            this.radioButtonPublic.Name = "radioButtonPublic";
            this.radioButtonPublic.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPublic.TabIndex = 14;
            this.radioButtonPublic.TabStop = true;
            this.radioButtonPublic.Text = "Public";
            this.radioButtonPublic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPrivate);
            this.groupBox1.Controls.Add(this.radioButtonPublic);
            this.groupBox1.Location = new System.Drawing.Point(25, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 46);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privacy:";
            // 
            // checkBoxGuestInvitationPrivelage
            // 
            this.checkBoxGuestInvitationPrivelage.AutoSize = true;
            this.checkBoxGuestInvitationPrivelage.Location = new System.Drawing.Point(31, 268);
            this.checkBoxGuestInvitationPrivelage.Name = "checkBoxGuestInvitationPrivelage";
            this.checkBoxGuestInvitationPrivelage.Size = new System.Drawing.Size(142, 17);
            this.checkBoxGuestInvitationPrivelage.TabIndex = 16;
            this.checkBoxGuestInvitationPrivelage.Text = "Guests can invite friends";
            this.checkBoxGuestInvitationPrivelage.UseVisualStyleBackColor = true;
            // 
            // FormDanielFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 327);
            this.Controls.Add(this.checkBoxGuestInvitationPrivelage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxRepetitions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEventImages);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.listBoxIntervals);
            this.Controls.Add(this.listBoxRepetitionPattern);
            this.Name = "FormDanielFeature";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRepetitionPattern;
        private System.Windows.Forms.ListBox listBoxIntervals;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelEventImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRepetitions;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
        private System.Windows.Forms.RadioButton radioButtonPublic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxGuestInvitationPrivelage;
    }
}