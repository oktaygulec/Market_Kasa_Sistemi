﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.Models
{
    public class Urun : IModel
    {
        private Kategori _kategori { get; set; }
        private Vergi _vergi { get; set; }
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunFiyat { get; set; }
        public int UrunStokAdet { get; set; }
        public int KategoriId { get; set; }
        public int VergiId { get; set; }
        public Kategori Kategori {
            get { return _kategori; }
            set
            {
                _kategori = value;
                KategoriId = _kategori.Id;
            }
        }
        public Vergi Vergi {
            get { return _vergi; }
            set
            {
                _vergi = value;
                VergiId = _vergi.Id;
            }
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("UrunAd", this.UrunAd),
                new SqlParameter("UrunFiyat", this.UrunFiyat),
                new SqlParameter("UrunStokAdet", this.UrunStokAdet),
                new SqlParameter("KategoriId", this.KategoriId),
                new SqlParameter("VergiId", this.VergiId),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("UrunBarkod", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["UrunBarkod"]);
            this.UrunAd = reader["UrunAd"].ToString();
            this.UrunFiyat = Convert.ToDecimal(reader["UrunFiyat"]);
            this.UrunStokAdet = Convert.ToInt32(reader["UrunStokAdet"]);
            this.Kategori.ReadItem(reader);
            this.Vergi.ReadItem(reader);
        }
    }
}