using Market_Kasa_Sistemi.DatabaseAccess.DatabaseContext;
using Market_Kasa_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.DatabaseAccess.Repositories
{
    public abstract class ARepository<T> where T : IModel
    {
        public readonly DBContext context;

        public ARepository(DBContext context)
        {
            this.context = context;
        }

        public abstract object Add(T item);
        public abstract T GetItem(object value);
        public abstract int Remove(object value);
        public abstract List<T> ToList();
        public abstract int Update(T item);
    }
}
