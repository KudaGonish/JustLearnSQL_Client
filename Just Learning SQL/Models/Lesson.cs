using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.Models
{
    class Lesson
    {
        public int LessonId { get; set; }

        public string LessonName { get; set; }

        public string LessonDescription { get; set; }

        public string Course { get; set; }

        public string Module { get; set; }

        public string FileName { get; set; }

        public string FileTimeUpload { get; set; }

        public byte[] File { get; set; }
    }
}
