using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.Models
{
    public class Kategori : IModel
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("KategoriAd", this.KategoriAd)
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("KategoriId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["KategoriId"]);
            this.KategoriAd = reader["KategoriAd"].ToString();
        }
    }
}
