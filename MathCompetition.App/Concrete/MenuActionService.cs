using MathCompetition.App.Common;
using MathCompetition.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initializer();
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Results)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }

            return result;
        }

        private void Initializer()
        {
            AddResult(new MenuAction(1, "Add result", "Main"));
            AddResult(new MenuAction(2, "Remove result", "Main"));
            AddResult(new MenuAction(3, "Show result", "Main"));
            AddResult(new MenuAction(4, "List of results", "Main"));

            AddResult(new MenuAction(1, "KRZYZAK", "AddNewResultTypeView"));
            AddResult(new MenuAction(2, "PRYMUS", "AddNewResultTypeView"));
            AddResult(new MenuAction(3, "SZERYF", "AddNewResultTypeView"));
            AddResult(new MenuAction(4, "OLIMPIJCZYCY", "AddNewResultTypeView"));
        }
    }
}
