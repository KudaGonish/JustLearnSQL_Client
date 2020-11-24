using Just_Learning_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.Models
{
    class CoursesListInfo
    {
        public static List<Course> courses { get; set; }
        public static List<Lesson> lessons { get; set; }
        public static List<Module> modules { get; set; }
    }
}
