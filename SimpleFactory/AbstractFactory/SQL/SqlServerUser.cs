using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SQL中给根据id获取User表格的一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQL中给User表格添加一条消息");
        }
    }
}
