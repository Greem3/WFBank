using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{ 
    static class Database
    {
        public static FiDBEntities FiDB { get; set; } = new FiDBEntities();

        public static T Query<T>(Func<FiDBEntities, T> func) where T: class
        {
            using (FiDBEntities db = new FiDBEntities())
            {
                return func(db);
            }
        }
    }
}
