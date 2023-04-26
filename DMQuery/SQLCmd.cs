using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMQuery
{
    internal class SQLCmd
    {
        public static DataTable Selecionar(string query)
        {
            try
            {
                //SqlCommand cmd = new SqlCommand(query, Conexao.conn);
                //cmd.CommandTimeout = 0;
                //DataTable dt = new DataTable();
                //dt.Load(cmd.ExecuteReader());
                //return dt;
                using (Conexao.conn)
                {
                    Conexao.Conectar();
                    using (SqlCommand cmd = new SqlCommand(query, Conexao.conn))
                    {
                        // criar um DataAdapter para executar a query e preencher um DataTable com o resultado
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // fazer algo com o DataTable aqui, por exemplo, exibir os dados em um DataGridView
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
