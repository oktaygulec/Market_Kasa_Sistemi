using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.Models
{
    public class Kullanici : IModel
    {
        private Personel _personel { get; set; }

        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public DateTime PersonelBaslangicTarih { get; set; }
        public PersonelTip PersonelTip { get; set; }
        public Personel Personel {
            get { return _personel; }
            set
            {
                _personel = value;
                PersonelId = _personel.Id;
                PersonelAd = _personel.PersonelAd;
                PersonelSoyad = _personel.PersonelSoyad;
                PersonelBaslangicTarih = _personel.PersonelBaslangicTarih;
                PersonelTip = _personel.PersonelTip;
            }
        }

        public SqlParameter GetIdParameter()
        {
            return new SqlParameter("KullaniciId", this.Id);
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("KullaniciAd", this.KullaniciAd),
                new SqlParameter("KullaniciSifre", this.KullaniciSifre),
                new SqlParameter("PersonelId", this.PersonelId),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(GetIdParameter());
            return parameters;
        }

        public List<SqlParameter> GetLoginParameters()
        {
            return new List<SqlParameter> {
                new SqlParameter("KullaniciAd", this.KullaniciAd),
                new SqlParameter("KullaniciSifre", this.KullaniciSifre),
            };
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["KullaniciId"]);
            this.KullaniciAd = reader["KullaniciAd"].ToString();
            this.KullaniciSifre = reader["KullaniciSifre"].ToString();

            this.Personel = new Personel();
            this.Personel.ReadItem(reader);
        }
    }
}
