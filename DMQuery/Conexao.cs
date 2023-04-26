using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMQuery
{
    internal class Conexao
    {
        public static SqlConnection conn;
        //"Data Source= SJC0652861W10-1;Initial Catalog= BANCO5;User= sa;Password= Senac123;";
        //"Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public static void Conectar()
        {
            string conexao = "";
            Configuracao config = Configuracao.lerConfig("Config.json");
            if (config.metodo == "Autenticação do Windows")
            {
                conexao = $"Server={config.servidor};Database=master;Trusted_Connection=True;";
            }
            else if (config.metodo == "Autenticação SQL Server")
            {
                conexao = $"Data Source= {config.servidor};User= {config.login};Password= {config.senha};";
            }
            conn = new SqlConnection(conexao);
            conn.Open();
        }
        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
