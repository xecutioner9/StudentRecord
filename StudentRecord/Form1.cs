using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRecord
{
    public partial class frmStudentInput : Form
    {
        public frmStudentInput()
        {
            InitializeComponent();
        }

        int[] days = new int[12];
        Student student; 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentInput_Load(object sender, EventArgs e)
        {
            student = new Student();
            days[0] = 31;
            days[1] = 28;
            days[2] = 31;
            days[3] = 30;
            days[4] = 31;
            days[5] = 28;
            days[6] = 31;
            days[7] = 31; 
            days[8] = 30;
            days[9] = 31;
            days[10] = 30;
            days[11] = 31;

            dudMonth.SelectedIndex = 0; 


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(dlgOpen.FileName);
            }
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            picStudent.Image = null;

        }

        private void rdaGrade_CheckedChanged(object sender, EventArgs e)
        {
            switch(((RadioButton)sender).Text)
            {
                case "Grade 1":
                    student.Grade = "first";
                    break;
                case "Grade 2":
                    student.Grade = "second";
                    break;
                case "Grade 3":
                    student.Grade = "third";
                    break;
                case "Grade 4":
                    student.Grade = "fourth";
                    break;
                case "Grade 5":
                    student.Grade = "fifth";
                    break;
                case "Grade 6":
                    student.Grade = "sixth";
                    break;


            }
        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            int isLeap = 0;
            int m, d, y;

            if(txtName.Text == "")
            {
                MessageBox.Show("Name is required", "Invlaid Inout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.Name = txtName.Text;

            if (radMale.Checked)
                student.Sex = "Male";
            else
                student.Sex = "Female";
            // 1. check if is it a february
            //2. check if leap ear - leap year is if uyear is divisinle by 4 but not fdivisiable byy 100
            if (dudMonth.SelectedIndex == 1 && nudYear.Value % 4 == 0 && nudYear.Value % 100 != 0)
                isLeap = 1;
            else
                isLeap = 0;

            if(nudDay.Value > days[dudMonth.SelectedIndex] + isLeap)
            {
                MessageBox.Show($"Only  {days[dudMonth.SelectedIndex] + isLeap} dats in {dudMonth.SelectedItem}", "Invalud Birth Day", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            m = Convert.ToInt32(DateTime.Today.Month) - 1;
            d = Convert.ToInt32(DateTime.Today.Day);
            y = Convert.ToInt32(DateTime.Today.Year);

            student.Age = y - Convert.ToInt32(nudYear.Value);
            if (dudMonth.SelectedIndex > m || (dudMonth.SelectedIndex == m && nudDay.Value > d))
                student.Age--;

            if (student.Age < 0)
            {
                MessageBox.Show("Birth date is before current date", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(student.StudentProfile(), "Student Prodile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
