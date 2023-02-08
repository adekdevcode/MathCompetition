using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition
{
    public class ResultService
    {
        public List<Result> Results { get; set; }

        public ResultService()
        {
            Results = new List<Result>();
        }

        public ConsoleKeyInfo AddNewResultView(MenuActionService menuActionService)
        {
            var addNewResultType = menuActionService.GetMenuActionsByMenuName("AddNewResultTypeView");

            Console.WriteLine("Please select Game : ");

            for (int i = 0; i < addNewResultType.Count; i++)
            {
                Console.WriteLine($"{addNewResultType[i].Id}. {addNewResultType[i].Name}");
            }

            var operation = Console.ReadKey();

            Console.WriteLine();

            return operation;
        }

        public int AddNewResult(char resultType)
        {
            int resultTypeId;
            Int32.TryParse(resultType.ToString(), out resultTypeId);

            Result result = new Result();
            result.ResultTypeId = resultTypeId;
            Console.WriteLine("Please enter id for new item: ");
            var id = Console.ReadLine();
            int resultId;
            Int32.TryParse(id, out resultId);

            result.Id = resultId;

            if (resultTypeId == 2 || resultTypeId == 3)
            {
                Console.WriteLine("Please enter points: ");
                var points = int.Parse(Console.ReadLine());
                result.Ponits = points;
            } else
            {
                Console.WriteLine("Please enter time: ");
                var resultTime = TimeOnly.Parse(Console.ReadLine());
                result.ResultTime = resultTime;
            }
            
            Results.Add(result);
            return resultId;
        }

        public int RemoveResultView()
        {
            Console.WriteLine("Please enter id for result you want to removed: ");
            var resultId = Console.ReadKey();
            int id;
            Int32.TryParse(resultId.KeyChar.ToString(), out id);

            return id;
        }

        public void RemoveResult(int removeId)
        {
            Result resultToRemove = new Result();

            foreach (var elem in Results)
            {
                if (elem.Id == removeId)
                {
                    resultToRemove = elem;
                    break;
                }
            }
            Results.Remove(resultToRemove);
        }

        public void ResultDetailView(int detailId)
        {
            Result resultToShow = new Result();

            foreach (var elem in Results)
            {
                if (elem.Id == detailId)
                {
                    resultToShow = elem;
                    break;
                }
            }

            Console.WriteLine($"Result id: {resultToShow.Id}");

            Console.WriteLine($"Result type id: {resultToShow.ResultTypeId}");

            if (resultToShow.ResultTypeId == 2 || resultToShow.ResultTypeId == 3)
            {
                Console.WriteLine($"Result points : {resultToShow.Ponits}");
            } else
            {
                Console.WriteLine($"Result Time : {resultToShow.ResultTime}");
            }
            
        }

        public int DetailSelectionResultView()
        {
            Console.WriteLine("Please enter id for item you want to show: ");
            var resultId = Console.ReadKey();
            int id;
            Int32.TryParse(resultId.KeyChar.ToString(), out id);

            return id;
        }

        public int ResultTypeSelectionView()
        {
            Console.WriteLine("Please enter ResultType Id for result type you want to show: ");
            var resultId = Console.ReadKey();
            int id;
            
            Int32.TryParse(resultId.KeyChar.ToString(), out id);

            return id;
        }

        public void ResultByTypeIdView(int resultId)
        {
            List<Result> results = new List<Result>();

            foreach (var elem in Results)
            {
                if (elem.ResultTypeId == resultId)
                {
                    results.Add(elem);
                }
            }

            results.ForEach(el => Console.WriteLine($"Result Id : {el.Id}, ResultType Id : {el.ResultTypeId} Result Time : {el.ResultTime}"));
        }
    }
}
