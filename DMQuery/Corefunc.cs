using ClosedXML.Excel;
using System;
using System.Drawing;
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
        public bool periodoSelec;
        public Control periodoDesc(string opcao, Control cmbQuandoRodar)
        {
            Point posicaoCmb = cmbQuandoRodar.Location;
            this.periodoSelec = true;
            switch (opcao)
            {
                case "Semanal":
                    string[] dias = new string[] { "Domingo", "Segunda", "Terca-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira" };
                    ComboBox cmbDia = new ComboBox();
                    cmbDia.Items.AddRange(dias);
                    cmbDia.SelectedIndex = 1;
                    cmbDia.Height = cmbQuandoRodar.Height;
                    cmbDia.Width = cmbQuandoRodar.Width;
                    cmbDia.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return cmbDia;
                case "Mensal":
                    string[] diasM = new string[] { "Primeiro dia", "Ultimo dia", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
                    ComboBox cmbDiaM = new ComboBox();
                    cmbDiaM.Items.AddRange(diasM);
                    cmbDiaM.SelectedIndex = 0;
                    cmbDiaM.Height = cmbQuandoRodar.Height;
                    cmbDiaM.Width = cmbQuandoRodar.Width;
                    cmbDiaM.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return cmbDiaM;
                case "Chamado GLPI":
                    TextBox descGLPI = new TextBox();
                    descGLPI.Text = "Assunto/Solicitante(s)";
                    descGLPI.Height = cmbQuandoRodar.Height;
                    descGLPI.Width = cmbQuandoRodar.Width + 30;
                    descGLPI.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return descGLPI;
                case "Email":
                    TextBox descEmail = new TextBox();
                    descEmail.Text = "Assunto/Email(s) solicitante(s)";
                    descEmail.Height = cmbQuandoRodar.Height;
                    descEmail.Width = cmbQuandoRodar.Width + 10;
                    descEmail.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return descEmail;
                case "Outro":
                    TextBox descOutro = new TextBox();
                    descOutro.Text = "Detalhes...";
                    descOutro.Height = cmbQuandoRodar.Height;
                    descOutro.Width = cmbQuandoRodar.Width + 10;
                    descOutro.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return descOutro;

            }
            return null;

        }
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
