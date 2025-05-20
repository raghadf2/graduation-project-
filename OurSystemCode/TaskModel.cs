using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurSystemCode
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
    }
}
