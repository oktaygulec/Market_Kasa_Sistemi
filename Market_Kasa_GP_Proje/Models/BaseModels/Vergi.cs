using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public class Vergi : IModel
    {
        public int Id { get; set; }
        public int VergiMiktar { get; set; }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("VergiMiktar", this.VergiMiktar)
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("VergiId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["VergiId"]);
            this.VergiMiktar = Convert.ToInt32(reader["VergiMiktar"]);
        }
    }
}
