﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public class PersonelTip : IModel
    {
        public int Id { get; set; }
        public string PersonelTipAd { get; set; }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> {
                new SqlParameter("PersonelTipAd", this.PersonelTipAd)
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("PersonelTipId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["PersonelTipId"]);
            this.PersonelTipAd = reader["PersonelTipAd"].ToString();
        }
    }
}
