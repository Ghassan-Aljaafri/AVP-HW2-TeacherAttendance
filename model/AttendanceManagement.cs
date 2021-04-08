using System;
using System.Collections.Generic;

namespace TeacherAttendance.model
{
    public class AttendanceManagement
    {
        private readonly List<Course> courses = new List<Course>();
        private readonly List<Teacher> teachers = new List<Teacher>();
        private readonly List<Room> rooms = new List<Room>();
        private readonly List<Attendance> attendances = new List<Attendance>();

        public void AddNewCourse(string courseName)
        {
            courses.Add(new Course(courses.Count + 1, courseName));
        }

        public List<Course> GetAllCourses()
        {
            var temp = courses.GetRange(0, courses.Count);
            temp.Add(new Course(0, "Add new course..."));
            return temp;
        }

        public void AddNewTeacher(string teacherName)
        {
            teachers.Add(new Teacher(teachers.Count + 1, teacherName));
        }

        public List<Teacher> GetAllTeachers()
        {
            var temp = teachers.GetRange(0, teachers.Count);
            temp.Add(new Teacher(0, "Add new course..."));
            return temp;
        }

        public void AddNewRoom(string roomName)
        {
            rooms.Add(new Room(rooms.Count + 1, roomName));
        }

        public List<Room> GetAllRooms()
        {
            var temp = rooms.GetRange(0, rooms.Count);
            temp.Add(new Room(0, "Add new room/lab..."));
            return temp;
        }

        public void AddNewAttendance(string teacherId, string courseId, string roomId, string date, string startTime, string leaveTime, string comment)
        {
            this.attendances.Add(new Attendance(teacherId, courseId, roomId, date, startTime, leaveTime, comment));
        }

        public List<Attendance> GetAllAttendances()
        {
            return this.attendances;
        }
    }
}