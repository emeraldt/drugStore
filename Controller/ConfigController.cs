using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Pharmacy.Codes;

namespace Pharmacy.Controller
{
    public class ConfigController
    {
        public DataTable getData(int id)
        {
            var table = new DataTable();
            var cmd = new SqlDataAdapter("select * from tReference where ref_id=" + id + "", DBRes.sql_conn);

            cmd.Fill(table);

            return table;
        }
    }
}
