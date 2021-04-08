using System;

namespace TeacherAttendance.model
{
    public class Attendance
    {
        public string TeacherId { get; set; }
        public string CourseId { get; set; }
        public string RoomId { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string LeaveTime { get; set; }
        public string Comment { get; set; }

        public Attendance(string teacherId, string courseId, string roomId, string date, string startTime, string leaveTime, string comment)
        {
            TeacherId = teacherId;
            CourseId = courseId;
            RoomId = roomId;
            Date = date;
            StartTime = startTime;
            LeaveTime = leaveTime;
            Comment = comment;
        }
    }
}