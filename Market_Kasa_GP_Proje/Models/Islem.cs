using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public class Islem : IModel
    {
        private Fis _fis { get; set; }
        private Urun _urun { get; set; }
        private Durum _durum { get; set; }
        public int Id { get; set; }
        public int IslemAdet { get; set; }
        public int FisId { get; set; }
        public int UrunBarkod { get; set; }
        public int DurumId { get; set; }
        public Fis Fis {
            get { return _fis; }
            set
            {
                _fis = value;
                FisId = _fis.Id;
            }
        }
        public Urun Urun {
            get { return _urun; }
            set
            {
                _urun = value;
                UrunBarkod = _urun.Id;
            }
        }
        public Durum Durum {
            get { return _durum; }
            set
            {
                _durum = value;
                DurumId = _durum.Id;
            }
        }
        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("IslemAdet", this.IslemAdet),
                new SqlParameter("FisId", this.FisId),
                new SqlParameter("UrunBarkod", this.UrunBarkod),
                new SqlParameter("DurumId", this.DurumId),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("IslemId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["IslemId"]);
            this.IslemAdet = Convert.ToInt32(reader["IslemAdet"]);
            this.Fis.ReadItem(reader);
            this.Urun.ReadItem(reader);
            this.Durum.ReadItem(reader);
        }
    }
}
