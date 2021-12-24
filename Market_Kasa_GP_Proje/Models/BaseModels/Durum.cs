using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public class Durum : IModel
    {
        public int Id { get ; set ; }
        public string DurumAd { get; set; }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter>{
                new SqlParameter("@DurumAd", this.DurumAd),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("DurumId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["DurumId"]);
            this.DurumAd = reader["DurumAd"].ToString();
        }
    }
}
