using Market_Kasa_Sistemi.DatabaseAccessLayer.DatabaseContext;
using Market_Kasa_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.DatabaseAccessLayer.Repositories
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
        public abstract int Remove(T item);
        public abstract List<T> ToList();
        public abstract int Update(T item);
    }
}
