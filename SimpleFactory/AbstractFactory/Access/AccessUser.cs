using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据id获取到user表格的一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表格添加一条记录");
        }
    }
}
