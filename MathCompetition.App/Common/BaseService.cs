using MathCompetition.App.Abstract;
using MathCompetition.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Results { get; set; }

        public BaseService()
        {
            Results = new List<T>();
        }

        public int AddResult(T result)
        {
            Results.Add(result);
            return result.Id;
        }

        public List<T> GetAllResults()
        {
            return Results;
        }

        public int GetLatId()
        {
            int lastId = 0;
            if (Results.Any())
            {
                lastId = Results.OrderBy(r => r.Id).LastOrDefault().Id;
            } else
            {
                lastId = 0;
            }
            return lastId;
        }

        public T GetResultById(int id)
        {
            var entity = Results.FirstOrDefault(r => r.Id == id);
            return entity;
        }

        public void RemoveResult(T result)
        {
            Results.Remove(result);
        }

        public int UpdateResult(T result)
        {
            var entity = Results.FirstOrDefault(r => r.Id == result.Id);

            if (entity != null)
            {
                entity = result;
            }

            return entity.Id;
        }
    }
}
