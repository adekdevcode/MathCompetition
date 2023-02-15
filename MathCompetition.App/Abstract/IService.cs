using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition.App.Abstract
{
    public interface IService<T>
    {
        List<T> Results { get; set; }
        List<T> GetAllResults();
        int GetLatId();
        T GetResultById(int id);
        int AddResult(T result);
        int UpdateResult(T result);
        void RemoveResult(T result);
    }
}
