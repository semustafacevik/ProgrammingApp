using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.DAL
{
    public class UsersDAL : BaseDAL
    {
        public Users GetUserByApiKey(string apiKey)
        {
            return db.Users.FirstOrDefault(x => x.userKey.ToString() == apiKey);
        }

        public Users GetUserByName(string name)
        {
            return db.Users.FirstOrDefault(x => x.name == name);
        }
    }
}
