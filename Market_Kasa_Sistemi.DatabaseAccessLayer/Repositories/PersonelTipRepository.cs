﻿using Market_Kasa_Sistemi.DatabaseAccessLayer.DatabaseContext;
using Market_Kasa_Sistemi.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.DatabaseAccessLayer.Repositories
{
    public class PersonelTipRepository : ARepository<PersonelTip>
    {
        public PersonelTipRepository(DBContext context) : base(context) { }

        public override object Add(PersonelTip item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPPersonelTipAdd", item.GetInsertParameters()))
            {
                return context.ExecuteScalar(cmd);
            }
        }

        public override PersonelTip GetItem(object value)
        {
            using (SqlCommand cmd = context.CreateCommand("SPPersonelTipGetById", new SqlParameter("@PersonelTipId", value)))
            {
                return context.GetItem<PersonelTip>(cmd);
            }
        }

        public override int Remove(PersonelTip item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPPersonelTipDelete", item.GetIdParameter()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }

        public override List<PersonelTip> ToList()
        {
            using (SqlCommand cmd = context.CreateCommand("SPPersonelTipGetAll"))
            {
                return context.ToList<PersonelTip>(cmd);
            }
        }

        public override int Update(PersonelTip item)
        {
            using (SqlCommand cmd = context.CreateCommand("SPPersonelTipUpdate", item.GetUpdateParameters()))
            {
                return context.ExecuteNonQuery(cmd);
            }
        }
    }
}
