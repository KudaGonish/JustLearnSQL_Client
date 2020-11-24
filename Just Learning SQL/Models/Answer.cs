using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.Models
{
    class Answer
    {
        public int LessonId { get; set; }

        public string SNM { get; set; }

        public string PKNumber { get; set; }

        public string AnswerType { get; set; }

        public string Text { get; set; }

        public byte[] Image { get; set; }

        public byte[] File { get; set; }

        public string FileName { get; set; }
    }
}
