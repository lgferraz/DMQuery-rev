using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DMQuery
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        public string nomeRelatorio = "*";
        public string abrirDialogo()
        {
            OpenFileDialog queryFile = new OpenFileDialog();
            queryFile.InitialDirectory = Directory.GetCurrentDirectory();
            queryFile.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";
            queryFile.FilterIndex = 1;
            while (queryFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Query não especificada");
                return "";
            }
            return queryFile.FileName.ToString();
        }
        public string salvarDialogo()
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
        public XLWorkbook gerarRelatorio(string query)
        {
            return Arquivos.Excel(SQLCmd.Selecionar(query));
        }
        public void salvarRelatorio(XLWorkbook relatorio)
        {
            if (chkSomenteParaMim.Checked == false)
            {
                if (txtArquivoQuery.Text != "")
                {
                    if (txtArquivoRequerente.Text != "")
                    {
                        relatorio.SaveAs(txtArquivoRequerente.Text);
                        relatorio.SaveAs("RelatoriosGerados/" + nomeRelatorio);
                    }
                    else
                    {
                        relatorio.SaveAs(salvarDialogo());
                        relatorio.SaveAs("RelatoriosGerados/" + nomeRelatorio);
                    }
                }
                else
                {
                    string caminho = salvarDialogo();
                    relatorio.SaveAs(caminho);
                    Regex regex = new Regex(@"[^\\]*$");
                    Match match = regex.Match(caminho);
                    if (match.Success)
                    {
                        string nomeDoArquivo = match.Value;
                        relatorio.SaveAs("RelatoriosGerados/" + DateTime.Now.ToString("ddMMyyyy") + "-" + nomeDoArquivo + ".xlsx");
                    }

                }
            }
            else
            {
                if (txtArquivoQuery.Text != "")
                {
                    relatorio.SaveAs("RelatoriosGerados/" + nomeRelatorio);
                }
                else
                {
                    relatorio.SaveAs(salvarDialogo());
                }
            }
        }
        public void lerQuery(string queryArquivo)
        {
            try
            {
                StreamReader querytxt = new StreamReader(queryArquivo);
                FileInfo arquivo = new FileInfo(queryArquivo);
                nomeRelatorio = arquivo.Name.ToString();
                nomeRelatorio = nomeRelatorio.Substring(0, nomeRelatorio.IndexOf(".")).Replace(" ", "-");
                nomeRelatorio = DateTime.Now.ToString("ddMMyyyy") + "-" + nomeRelatorio + ".xlsx";
                txtQuery.Text = querytxt.ReadToEnd();
            }
            catch
            {
                //MessageBox.Show("Arquivo não especificado");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string queryFile = abrirDialogo();
            txtArquivoQuery.Text = queryFile;
            lerQuery(txtArquivoQuery.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lerQuery(txtArquivoQuery.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaminhoQuery_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
                txtArquivoQuery.Text = files.First();
        }

        private void txtCaminhoQuery_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtQuery_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null && files.Any())
                txtArquivoQuery.Text = files.First();
            lerQuery(files.First());


        }

        private void txtQuery_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtQuery.Text != "")
            {
                string query = txtQuery.Text;
                try
                {
                    btnExecutar.Enabled = false;
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Insira uma query");
            }
        }

        private void txtRequerente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string relatArquivo = salvarDialogo();
            txtArquivoRequerente.Text = relatArquivo;

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string query = txtQuery.Text;
                XLWorkbook relat = gerarRelatorio(query);
                e.Result = relat;
            }
            catch
            {
                //
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Query Cancelada");
                btnExecutar.Enabled = true;
            }
            else
            {
                XLWorkbook relat = (XLWorkbook)e.Result;
                try
                {
                    salvarRelatorio(relat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnExecutar.Enabled = true;
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
        private void novaRotinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}