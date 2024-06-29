
namespace StudentRecord
{
    partial class frmStudentInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGrade6 = new System.Windows.Forms.RadioButton();
            this.radGrade5 = new System.Windows.Forms.RadioButton();
            this.radGrade4 = new System.Windows.Forms.RadioButton();
            this.radGrade3 = new System.Windows.Forms.RadioButton();
            this.radGrade2 = new System.Windows.Forms.RadioButton();
            this.radGrade1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.dudMonth = new System.Windows.Forms.DomainUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnShowProfile = new System.Windows.Forms.Button();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Location = new System.Drawing.Point(31, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(25, 42);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(25, 19);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 0;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGrade6);
            this.groupBox2.Controls.Add(this.radGrade5);
            this.groupBox2.Controls.Add(this.radGrade4);
            this.groupBox2.Controls.Add(this.radGrade3);
            this.groupBox2.Controls.Add(this.radGrade2);
            this.groupBox2.Controls.Add(this.radGrade1);
            this.groupBox2.Location = new System.Drawing.Point(36, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade Level";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radGrade6
            // 
            this.radGrade6.AutoSize = true;
            this.radGrade6.Location = new System.Drawing.Point(21, 139);
            this.radGrade6.Name = "radGrade6";
            this.radGrade6.Size = new System.Drawing.Size(63, 17);
            this.radGrade6.TabIndex = 5;
            this.radGrade6.Text = "Grade 6";
            this.radGrade6.UseVisualStyleBackColor = true;
            this.radGrade6.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // radGrade5
            // 
            this.radGrade5.AutoSize = true;
            this.radGrade5.Location = new System.Drawing.Point(21, 115);
            this.radGrade5.Name = "radGrade5";
            this.radGrade5.Size = new System.Drawing.Size(63, 17);
            this.radGrade5.TabIndex = 4;
            this.radGrade5.Text = "Grade 5";
            this.radGrade5.UseVisualStyleBackColor = true;
            this.radGrade5.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // radGrade4
            // 
            this.radGrade4.AutoSize = true;
            this.radGrade4.Location = new System.Drawing.Point(21, 92);
            this.radGrade4.Name = "radGrade4";
            this.radGrade4.Size = new System.Drawing.Size(63, 17);
            this.radGrade4.TabIndex = 3;
            this.radGrade4.Text = "Grade 4";
            this.radGrade4.UseVisualStyleBackColor = true;
            this.radGrade4.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // radGrade3
            // 
            this.radGrade3.AutoSize = true;
            this.radGrade3.Location = new System.Drawing.Point(21, 68);
            this.radGrade3.Name = "radGrade3";
            this.radGrade3.Size = new System.Drawing.Size(63, 17);
            this.radGrade3.TabIndex = 2;
            this.radGrade3.Text = "Grade 3";
            this.radGrade3.UseVisualStyleBackColor = true;
            this.radGrade3.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // radGrade2
            // 
            this.radGrade2.AutoSize = true;
            this.radGrade2.Location = new System.Drawing.Point(21, 44);
            this.radGrade2.Name = "radGrade2";
            this.radGrade2.Size = new System.Drawing.Size(63, 17);
            this.radGrade2.TabIndex = 1;
            this.radGrade2.Text = "Grade 2";
            this.radGrade2.UseVisualStyleBackColor = true;
            this.radGrade2.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // radGrade1
            // 
            this.radGrade1.AutoSize = true;
            this.radGrade1.Checked = true;
            this.radGrade1.Location = new System.Drawing.Point(20, 20);
            this.radGrade1.Name = "radGrade1";
            this.radGrade1.Size = new System.Drawing.Size(63, 17);
            this.radGrade1.TabIndex = 0;
            this.radGrade1.TabStop = true;
            this.radGrade1.Text = "Grade 1";
            this.radGrade1.UseVisualStyleBackColor = true;
            this.radGrade1.CheckedChanged += new System.EventHandler(this.rdaGrade_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudYear);
            this.groupBox3.Controls.Add(this.nudDay);
            this.groupBox3.Controls.Add(this.dudMonth);
            this.groupBox3.Location = new System.Drawing.Point(218, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date of Birth";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(7, 72);
            this.nudYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(168, 20);
            this.nudYear.TabIndex = 2;
            this.nudYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(6, 45);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(169, 20);
            this.nudDay.TabIndex = 1;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dudMonth
            // 
            this.dudMonth.Items.Add("January");
            this.dudMonth.Items.Add("February");
            this.dudMonth.Items.Add("March");
            this.dudMonth.Items.Add("April");
            this.dudMonth.Items.Add("May");
            this.dudMonth.Items.Add("June");
            this.dudMonth.Items.Add("July");
            this.dudMonth.Items.Add("August");
            this.dudMonth.Items.Add("September");
            this.dudMonth.Items.Add("October");
            this.dudMonth.Items.Add("November");
            this.dudMonth.Items.Add("December");
            this.dudMonth.Location = new System.Drawing.Point(6, 19);
            this.dudMonth.Name = "dudMonth";
            this.dudMonth.Size = new System.Drawing.Size(169, 20);
            this.dudMonth.TabIndex = 0;
            this.dudMonth.Text = "January";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picStudent);
            this.groupBox4.Location = new System.Drawing.Point(222, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 151);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture";
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(12, 20);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(214, 121);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 0;
            this.picStudent.TabStop = false;
            // 
            // btnShowProfile
            // 
            this.btnShowProfile.Location = new System.Drawing.Point(534, 265);
            this.btnShowProfile.Name = "btnShowProfile";
            this.btnShowProfile.Size = new System.Drawing.Size(116, 25);
            this.btnShowProfile.TabIndex = 6;
            this.btnShowProfile.Text = "Show Profile";
            this.btnShowProfile.UseVisualStyleBackColor = true;
            this.btnShowProfile.Click += new System.EventHandler(this.btnShowProfile_Click);
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(534, 298);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(116, 25);
            this.btnNewProfile.TabIndex = 7;
            this.btnNewProfile.Text = "New Profile";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(534, 338);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(116, 25);
            this.btnLoadPicture.TabIndex = 8;
            this.btnLoadPicture.Text = "Load Picture";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(534, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 25);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "JPEG (*.jpg)|*.jpg";
            this.dlgOpen.Title = "Load Student Picture";
            // 
            // frmStudentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadPicture);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.btnShowProfile);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmStudentInput";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.frmStudentInput_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGrade6;
        private System.Windows.Forms.RadioButton radGrade5;
        private System.Windows.Forms.RadioButton radGrade4;
        private System.Windows.Forms.RadioButton radGrade3;
        private System.Windows.Forms.RadioButton radGrade2;
        private System.Windows.Forms.RadioButton radGrade1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.DomainUpDown dudMonth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnShowProfile;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

