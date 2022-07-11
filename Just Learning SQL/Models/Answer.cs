using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Learning_SQL.Models
{
    class Answer
    {
        public int LectureId { get; set; }

        public string LFP { get; set; }

        public string PCNumber { get; set; }

        public string AnswerType { get; set; }

        public string AnswerFileName { get; set; }
        public byte[] AnswerFile { get; set; }

        public string AnswerText { get; set; }

        public byte[] AnswerImage { get; set; }


    }
}
