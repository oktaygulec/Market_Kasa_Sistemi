using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.Models
{
    public class OdemeTip : IModel
    {
        public int Id { get; set; }
        public string OdemeTipAd { get; set; }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> {
                new SqlParameter("OdemeTipAd", this.OdemeTipAd)
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("OdemeTipId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["OdemeTipId"]);
            this.OdemeTipAd = reader["OdemeTipAd"].ToString();
        }
    }
}
