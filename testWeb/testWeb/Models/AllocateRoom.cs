using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Expressions;

namespace testWeb.Models
{
    public class AllocateRoom
    {
        public int AllocateRoomId { set; get; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
        public int CourseId { set; get; }
        public virtual Course Course { set; get; }
        public int RoomId { set; get; }
        public virtual Room Room { set; get; }
        //public DateTime

    }
}