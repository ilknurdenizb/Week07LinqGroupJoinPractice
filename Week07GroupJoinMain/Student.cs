using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07GroupJoinMain
{   // This class represents a student with properties for StudentId, StudentName, and ClassId.
    // It is used in the group join operation to associate students with their respective classes.
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }
    }
}
