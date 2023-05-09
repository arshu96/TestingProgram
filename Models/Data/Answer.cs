using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public IEnumerable<string> SelectedVariants { get; set; }
        public int QuestionId { get; set; }
    }
}
