using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public enum QuestionType { OneAnswer, MultipleAnswers }

    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string ImagePath { get; set; }
        public IEnumerable<string> AnswerVariants { get; set; }
        public int Grade { get; set; }
        public QuestionType Type { get; set; }
    }
}
