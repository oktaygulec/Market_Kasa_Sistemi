﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.Models
{
    public class Satis : IModel
    {
        private Fis _fis { get; set; }
        private Urun _urun { get; set; }
        public int Id { get; set; }
        public int SatisAdet { get; set; }
        public int FisId { get; set; }
        public int UrunBarkod { get; set; }
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
            this.Fis.ReadItem(reader);
            this.Urun.ReadItem(reader);
        }
    }
}