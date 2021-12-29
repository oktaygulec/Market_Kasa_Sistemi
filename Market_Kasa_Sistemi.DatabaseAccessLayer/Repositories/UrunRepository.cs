using Market_Kasa_Sistemi.DatabaseAccessLayer.DatabaseContext;
using Market_Kasa_Sistemi.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.DatabaseAccessLayer.Repositories
{
    public class UrunRepository : ARepository<Urun>
    {
        public UrunRepository(DBContext context) : base(context) { }

        public override object Add(Urun item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPUrunAdd", item.GetInsertParameters()))
            {
                return context.ExecuteScalar(cmd);
            }
        }

        public override Urun GetItem(object value)
        {
            using (SqlCommand cmd = context.CreateCommand("SPUrunGetById", new SqlParameter("@UrunBarkod", value)))
            {
                return context.GetItem<Urun>(cmd);
            }
        }

        public override int Remove(Urun item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPUrunDelete", item.GetIdParameter()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }

        public override List<Urun> ToList()
        {
            using (SqlCommand cmd = context.CreateCommand("SPUrunGetAll"))
            {
                return context.ToList<Urun>(cmd);
            }
        }

        public override int Update(Urun item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPUrunUpdate", item.GetUpdateParameters()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }
    }
}
