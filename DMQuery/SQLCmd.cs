using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMQuery
{
    internal class SQLCmd
    {
        public static DataTable Selecionar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Conexao.conn);
            cmd.CommandTimeout=0;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
    }
}
