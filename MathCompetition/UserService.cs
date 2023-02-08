using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCompetition
{
    public class UserService
    {
        public List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>();
        }

    }
}
