namespace TeacherAttendance.model
{
    public class Room
    {
        public int RoomId { set; get; }
        public string RoomName { set; get; }
        
        public Room(int roomId, string roomName)
        {
            this.RoomId = roomId;
            this.RoomName = roomName;
        }
    }
}