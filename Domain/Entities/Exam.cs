using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public List<string> Questions { get; set; }
        public List<string> Anwsers { get; set; }
        public int Marks { get; set; }
    }
}
