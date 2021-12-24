using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Kasa_GP_Proje.Models
{
    public interface IModel
    {
        int Id { get; set; }

        void ReadItem(SqlDataReader reader);

        List<SqlParameter> GetInsertParameters();
        List<SqlParameter> GetUpdateParameters();
    }
}
