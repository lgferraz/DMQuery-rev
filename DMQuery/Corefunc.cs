using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMQuery
{
    internal class Corefunc
    {
        public static string abrirDialogo()
        {
            OpenFileDialog queryFile = new OpenFileDialog();
            queryFile.InitialDirectory = Directory.GetCurrentDirectory();
            queryFile.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
            queryFile.FilterIndex = 1;
            if (queryFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Query não especificada");
                return "";
            }
            return queryFile.FileName.ToString();
        }
        public static string salvarDialogo(string nomeRelatorio)
        {
            SaveFileDialog relatFile = new SaveFileDialog();
            relatFile.InitialDirectory = Directory.GetCurrentDirectory();
            relatFile.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            relatFile.FileName = nomeRelatorio;

            if (relatFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Caminho não especificado");
                return "";
            }
            return relatFile.FileName.ToString();
        }
        public static XLWorkbook gerarRelatorio(string query)
        {
            return Arquivos.Excel(SQLCmd.Selecionar(query));
        }
        public static string lerQuery(string queryArquivo, string nomeRelatorio)
        {
            try
            {
                StreamReader querytxt = new StreamReader(queryArquivo);
                FileInfo arquivo = new FileInfo(queryArquivo);
                nomeRelatorio = arquivo.Name.ToString();
                nomeRelatorio = nomeRelatorio.Substring(0, nomeRelatorio.IndexOf(".")).Replace(" ", "-");
                nomeRelatorio = DateTime.Now.ToString("ddMMyyyy") + "-" + nomeRelatorio + ".xlsx";
                return querytxt.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public static string pastaDialogo()
        {
            FolderBrowserDialog pasta = new FolderBrowserDialog();
            if (pasta.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Pasta não selecionada");
                return "";
            }
            return pasta.SelectedPath;
        }
    }
}
