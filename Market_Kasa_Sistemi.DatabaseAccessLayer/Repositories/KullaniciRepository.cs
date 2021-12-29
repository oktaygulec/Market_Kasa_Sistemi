using Market_Kasa_Sistemi.DatabaseAccessLayer.DatabaseContext;
using Market_Kasa_Sistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.DatabaseAccessLayer.Repositories
{
    public class KullaniciRepository : ARepository<Kullanici>
    {
        public KullaniciRepository(DBContext context) : base(context) { }

        public override object Add(Kullanici item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciAdd", item.GetInsertParameters()))
            {
                return context.ExecuteScalar(cmd);
            }
        }

        public override Kullanici GetItem(object value)
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciGetById", new SqlParameter("@KullaniciId", value)))
            {
                return context.GetItem<Kullanici>(cmd);
            }
        }

        public override int Remove(Kullanici item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciDelete", item.GetIdParameter()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }

        public override List<Kullanici> ToList()
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciGetAll"))
            {
                return context.ToList<Kullanici>(cmd);
            }
        }

        public override int Update(Kullanici item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciUpdate", item.GetUpdateParameters()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }

        public bool Login(Kullanici item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPKullaniciLogin", item.GetLoginParameters()))
            {
                return Convert.ToBoolean(context.ExecuteScalar(cmd));
            }
        }
    }
}
