using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public TimeSpan TestTime { get; set; }
    }
}
