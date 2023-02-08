using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition
{
    public class Result
    {
        public int Id { get; set; }
        public int ResultTypeId { get; set; }

        public TimeOnly? ResultTime { get; set; }
        public int? Ponits { get; set; }

        //public int? Mistakes { get; set; }

        //public User User { get; set; }
    }
}