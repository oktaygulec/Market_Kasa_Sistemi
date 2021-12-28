﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_Sistemi.Models
{
    public class Fis : IModel
    {
        private OdemeTip _odemeTip { get; set; }
        private Personel _personel { get; set; }

        public int Id { get; set; }
        public DateTime FisTarih { get; set; }
        public int OdemeTipId { get; set; }
        public string OdemeTipAd { get; set; }
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public DateTime PersonelBaslangicTarih { get; set; }
        public PersonelTip PersonelTip { get; set; }
        public OdemeTip OdemeTip {
            get { return _odemeTip; }
            set
            {
                _odemeTip = value;
                OdemeTipId = _odemeTip.Id;
                OdemeTipAd = _odemeTip.OdemeTipAd;
            }
        }
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
            return new SqlParameter("FisId", this.Id);
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("FisTarih", this.FisTarih),
                new SqlParameter("OdemeTipId", this.OdemeTipId),
                new SqlParameter("PersonelId", this.PersonelId),
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
            this.Id = Convert.ToInt32(reader["FisId"]);
            this.FisTarih = Convert.ToDateTime(reader["FisTarih"]);

            this.OdemeTip = new OdemeTip();
            this.OdemeTip.ReadItem(reader);

            this.Personel = new Personel();
            this.Personel.ReadItem(reader);
        }
    }
}
