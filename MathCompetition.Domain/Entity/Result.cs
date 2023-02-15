using MathCompetition.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition.Domain.Entity
{
    public class Result : BaseEntity
    {
        public int ResultTypeId { get; set; }

        public TimeOnly? ResultTime { get; set; }
        public int? Ponits { get; set; }
        //public int? Mistakes { get; set; }

        //public User User { get; set; }

        public Result(int id, int points, int resultTypeId)
        {
            this.Id = id;
            this.Ponits = points;
            this.ResultTypeId = resultTypeId;
        }

        public Result(int id, TimeOnly resultTime, int resultTypeId)
        {
            this.Id = id;
            this.ResultTime = resultTime;
            this.ResultTypeId = resultTypeId;
        }
        
    }
}
