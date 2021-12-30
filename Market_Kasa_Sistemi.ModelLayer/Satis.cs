using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.Models
{
    public class Satis : IModel
    {
        public int Id { get; set; }
        public int SatisAdet { get; set; }
        public Fis Fis { get; set; }
        public Urun Urun { get; set; }

        public SqlParameter GetIdParameter()
        {
            return new SqlParameter("SatisId", this.Id);
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("SatisAdet", this.SatisAdet),
                new SqlParameter("FisId", this.Fis.Id),
                new SqlParameter("UrunBarkod", this.Urun.Id),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(GetIdParameter());
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["SatisId"]);
            this.SatisAdet = Convert.ToInt32(reader["SatisAdet"]);

            this.Fis = new Fis();
            this.Fis.ReadItem(reader);

            this.Urun = new Urun();
            this.Urun.ReadItem(reader);
        }
    }
}
