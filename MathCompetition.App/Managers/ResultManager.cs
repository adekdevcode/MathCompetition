using MathCompetition.App.Abstract;
using MathCompetition.App.Concrete;
using MathCompetition.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition.App.Managers
{
    public class ResultManager
    {
        private readonly MenuActionService _actionService;
        private IService<Result> _resultService;

        public ResultManager(MenuActionService actionService, IService<Result> resultService)
        {
            this._actionService = actionService;
            this._resultService = resultService;
        }

        public int AddNewResult()
        {
            var addNewResultMenu = _actionService.GetMenuActionsByMenuName("AddNewResultTypeView");
            Console.WriteLine("Please select Game : ");

            for (int i = 0; i < addNewResultMenu.Count; i++)
            {
                Console.WriteLine($"{addNewResultMenu[i].Id}. {addNewResultMenu[i].Name}");
            }

            var operation = Console.ReadKey();

            Console.WriteLine();

            int resultTypeId;
            Int32.TryParse(operation.KeyChar.ToString(), out resultTypeId);

            var lastId = _resultService.GetLatId();
            Result result;

            Console.WriteLine("Please insert reult: ");

            if (resultTypeId == 2 || resultTypeId == 3)
            {
                Console.WriteLine("Please enter points: ");
                var points = int.Parse(Console.ReadLine());
                result = new Result(lastId, points, resultTypeId);
            }
            else
            {
                Console.WriteLine("Please enter time: ");
                var resultTime = TimeOnly.Parse(Console.ReadLine());
                result = new Result(lastId, resultTime, resultTypeId);
            }

            _resultService.AddResult(result);

            return result.Id;
        }

        public void RemoveResultById(int id)
        {
            var result = _resultService.GetResultById(id);
            _resultService.RemoveResult(result);
        }

        public Result GetResultById(int id)
        {
            var result = _resultService.GetResultById(id);
            return result;
        }
    }
}
