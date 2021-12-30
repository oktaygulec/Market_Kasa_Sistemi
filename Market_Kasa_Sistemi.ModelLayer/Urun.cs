﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Market_Kasa_Sistemi.Models
{
    public class Urun : IModel
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public int UrunStokAdet { get; set; }
        public Kategori Kategori { get; set; }
        public Vergi Vergi { get; set; }

        public SqlParameter GetIdParameter()
        {
            return new SqlParameter("UrunId", this.Id);
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("UrunAd", this.UrunAd),
                new SqlParameter("UrunFiyat", this.UrunFiyat),
                new SqlParameter("UrunStokAdet", this.UrunStokAdet),
                new SqlParameter("KategoriId", this.Kategori.Id),
                new SqlParameter("VergiId", this.Vergi.Id),
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
            this.Id = Convert.ToInt32(reader["UrunBarkod"]);
            this.UrunAd = reader["UrunAd"].ToString();
            this.UrunFiyat = Convert.ToDecimal(reader["UrunFiyat"]);
            this.UrunStokAdet = Convert.ToInt32(reader["UrunStokAdet"]);

            this.Kategori = new Kategori();
            this.Kategori.ReadItem(reader);

            this.Vergi = new Vergi();
            this.Vergi.ReadItem(reader);
        }
    }
}
