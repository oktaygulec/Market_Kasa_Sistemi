using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public class Personel : IModel
    {
        private PersonelTip _personelTip { get; set; }

        public int Id { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public DateTime PersonelBaslangicTarih { get; set; }
        public int PersonelTipId { get; set; }
        public PersonelTip PersonelTip {
            get { return _personelTip; }
            set
            {
                _personelTip = value;
                PersonelTipId = _personelTip.Id;
            }
        }

        public List<SqlParameter> GetInsertParameters()
        {
            return new List<SqlParameter> { 
                new SqlParameter("PersonelAd", this.PersonelAd),
                new SqlParameter("PersonelSoyad", this.PersonelSoyad),
                new SqlParameter("PersonelBaslangicTarih", this.PersonelBaslangicTarih),
                new SqlParameter("PersonelTipId", this.PersonelTipId),
            };
        }

        public List<SqlParameter> GetUpdateParameters()
        {
            List<SqlParameter> parameters = GetInsertParameters();
            parameters.Add(new SqlParameter("PersonelId", this.Id));
            return parameters;
        }

        public void ReadItem(SqlDataReader reader)
        {
            this.Id = Convert.ToInt32(reader["PersonelId"]);
            this.PersonelAd = reader["PersonelAd"].ToString();
            this.PersonelSoyad = reader["PersonelSoyad"].ToString();
            this.PersonelBaslangicTarih = Convert.ToDateTime(reader["PersonelBaslangicTarih"]);
            this.PersonelTip.ReadItem(reader);

            //PersonelTip pTip = new PersonelTip();
            //pTip.ReadItem(reader);

            //this.PersonelTip = pTip;
        }
    }
}
