using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.Models
{
    public class Satis : IModel
    {
        private Fis _fis { get; set; }
        private Urun _urun { get; set; }
        public int Id { get; set; }
        public int SatisAdet { get; set; }

        public int FisId { get; set; }
        public DateTime FisTarih { get; set; }
        public OdemeTip OdemeTip { get; set; }
        public Personel Personel { get; set; }

        public int UrunBarkod { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public int UrunStokAdet { get; set; }
        public Kategori Kategori { get; set; }
        public Vergi Vergi { get; set; }
        public Fis Fis {
            get { return _fis; }
            set
            {
                _fis = value;
                FisId = _fis.Id;
                FisTarih = _fis.FisTarih;
                OdemeTip = _fis.OdemeTip;
                Personel = _fis.Personel;
            }
        }
        public Urun Urun {
            get { return _urun; }
            set
            {
                _urun = value;
                UrunBarkod = _urun.Id;
                UrunAd = _urun.UrunAd;
                UrunFiyat = _urun.UrunFiyat;
                UrunStokAdet = _urun.UrunStokAdet;
                Kategori = _urun.Kategori;
                Vergi = _urun.Vergi;
            }
        }

        public SqlParameter GetIdParameter()
        {
            return new SqlParameter("SatisId", this.Id);
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("SatisAdet", this.SatisAdet),
                new SqlParameter("FisId", this.FisId),
                new SqlParameter("UrunBarkod", this.UrunBarkod),
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
