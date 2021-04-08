namespace TeacherAttendance.model
{
    public class Teacher
    {
        public int TeacherId { set; get; }
        public string TeacherName { set; get; }
        
        public Teacher(int teacherId, string teacherName)
        {
            this.TeacherId = teacherId;
            this.TeacherName = teacherName;
        }
    }
}