using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentProperties
    {
        public Property<string> FirstName { get; set; }
        public Property<string> LastName { get; set; }
        public Property<int> Age { get; set; }
        public Property<IEnumerable<StudentCourseProperties>> StudentCourse { get; set; }

    }
    public class StudentCourseProperties
    {
        public int StudentId { get; set; }
        public int Course { get; set; }
    }
}
