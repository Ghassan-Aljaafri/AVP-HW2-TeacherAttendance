using System;
using System.Windows.Forms;
using TeacherAttendance.helper;
using TeacherAttendance.model;

namespace TeacherAttendance
{
    public partial class frmTeacherAttendance : Form
    {
        private AttendanceManagement attendance;

        public frmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void FrmTeacherAttendance_Load(object sender, EventArgs e)
        {
            attendance = new AttendanceManagement();
            ShowCourses();
            ShowTeachers();
            ShowRooms();

            dataGridView1.DataSource = attendance.GetAllAttendances();
        }

        /*private void CmbCourses_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }*/

        private void ShowCourses()
        {
            cmbCourses.DataSource = null;
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseId";
            cmbCourses.DataSource = attendance.GetAllCourses();
            cmbCourses.SelectedIndex = -1;
        }

        private void ShowTeachers()
        {
            cmbTeacherName.DataSource = null;
            cmbTeacherName.DisplayMember = "TeacherName";
            cmbTeacherName.ValueMember = "TeacherId";
            cmbTeacherName.DataSource = attendance.GetAllTeachers();
            cmbTeacherName.SelectedIndex = -1;
        }

        private void ShowRooms()
        {
            cmbRoom.DataSource = null;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomId";
            cmbRoom.DataSource = attendance.GetAllRooms();
            cmbRoom.SelectedIndex = -1;
        }

        private void CmbCourses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";
            
            var id = ((Course) ((ComboBox) sender).SelectedItem).CourseId;

            if (id != 0) return;

            if (Prompt.InputBox("New course", "New course name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.AddNewCourse(value.Trim());
                    ShowCourses();
                }
        }

        private void CmbTeacherName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";

            var id = ((Teacher) ((ComboBox) sender).SelectedItem).TeacherId;

            if (id != 0) return;

            if (Prompt.InputBox("New teacher", "New teacher name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.AddNewTeacher(value.Trim());
                    ShowTeachers();
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbRoom.SelectedIndex == -1 || cmbCourses.SelectedIndex == -1 || cmbTeacherName.SelectedIndex == -1)
            {
                MessageBox.Show("please fill all the fields.");
            }
            else
            {
                attendance.AddNewAttendance(cmbTeacherName.Text, cmbCourses.Text, cmbRoom.Text, dateTimePicker1.Text, dateTimePicker2.Text, dateTimePicker3.Text, textBox2.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = attendance.GetAllAttendances();
            }
        }

        private void CmbRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";


            var id = ((Room) ((ComboBox) sender).SelectedItem).RoomId;

            if (id != 0) return;

            if (Prompt.InputBox("New Room/Lab", "New Room/Lab name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    attendance.AddNewRoom(value.Trim());
                    ShowRooms();
                }
        }
    }
}