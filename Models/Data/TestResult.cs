using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class TestResult
    {
        public int Id { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public DateTime CompletionTime { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
    }
}
