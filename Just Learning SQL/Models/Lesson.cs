using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.Models
{
    class Lecture
    {
        public int LectureId { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public byte[] LectureFile { get; set; }
    }
}
