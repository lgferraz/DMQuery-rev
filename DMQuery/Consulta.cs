﻿using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public void limparRot()
        {
            txtArquivoQuery.Text = "";
            txtArquivoRequerente.Text = "";
            txtQuery.Text = "";
            nomeRelatorio = "*";
        }
        public void limpar()
        {
            txtArquivoQuery.Text = "";
            txtArquivoRequerente.Text = "";
            txtQuery.Text = "";
            cmbRotinas.Text = "";
            nomeRelatorio = "*";
        }
        public void carregarRotinas()
        {
            try
            {
                string[] rotinas = Rotina.lerRotinas();
                foreach (string rotina in rotinas)
                {
                    if (!cmbRotinas.Items.Contains(rotina))
                    {
                        cmbRotinas.Items.Add(rotina);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

            if (chkSomenteParaMim.Checked && nomeRelatorio == "*")
            {
                relatorio.SaveAs(salvarDialogo());
                relatorio.SaveAs("RelatoriosGerados/" + nomeRelatorio);
            }
            else if (chkSomenteParaMim.Checked)
            {
                relatorio.SaveAs("RelatoriosGerados/" + nomeRelatorio);
            }
            else
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
        }
        public void lerQuery(string queryArquivo)
        {
            txtQuery.Text = Corefunc.lerQuery(queryArquivo, nomeRelatorio);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string queryFile = abrirDialogo();
            txtArquivoQuery.Text = queryFile;
            lerQuery(txtArquivoQuery.Text);
            nomeRelatorio = queryFile;
            nomeRelatorio = Path.GetFileNameWithoutExtension(queryFile);
            nomeRelatorio = DateTime.Now.ToString("ddMMyyyy") + "-" + nomeRelatorio + ".xlsx";
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
                string queryFile = files.First();
                txtArquivoQuery.Text = queryFile;
                lerQuery(txtArquivoQuery.Text);
                nomeRelatorio = queryFile;
                nomeRelatorio = Path.GetFileNameWithoutExtension(queryFile);
                nomeRelatorio = DateTime.Now.ToString("ddMMyyyy") + "-" + nomeRelatorio + ".xlsx";


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
            carregarRotinas();
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

        private void cmbRotinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limparRot();
                Rotina rotina = Rotina.lerRotina(Directory.GetCurrentDirectory() + "\\Rotinas\\" + cmbRotinas.SelectedItem.ToString());
                txtQuery.Text = rotina.query_base;
                nomeRelatorio = DateTime.Now.ToString("ddMMyyyy") + "-" + rotina.nome_rotina + ".xlsx";
                txtArquivoRequerente.Text = rotina.pasta_requerente.Replace("\\", "/") + "/" + DateTime.Now.ToString("ddMMyyyy") + "-" + rotina.nome_rotina + ".xlsx";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void novaRotinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaRotina novaR = new NovaRotina();
            novaR.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carregarRotinas();
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consultaN = new Consulta();
            consultaN.Show();
        }
    }
}