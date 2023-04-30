using DocumentFormat.OpenXml.Office2010.PowerPoint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMQuery
{
    public partial class NovaRotina : Form
    {
        public NovaRotina()
        {
            InitializeComponent();
            cmbQuandoRodar.SelectedIndex = 0;
        }

        public bool periodoSelec = false;
        public Control controleSelec;
        private Control periodoDesc(string opcao)
        {
            Point posicaoCmb = cmbQuandoRodar.Location;
            periodoSelec = true;
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
                    descGLPI.Width = cmbQuandoRodar.Width+30;
                    descGLPI.Location = new Point(posicaoCmb.X * 10, posicaoCmb.Y);
                    return descGLPI;
                case "Email":
                    TextBox descEmail = new TextBox();
                    descEmail.Text = "Assunto/Email(s) solicitante(s)";
                    descEmail.Height = cmbQuandoRodar.Height;
                    descEmail.Width = cmbQuandoRodar.Width+10;
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

        private void txtArquivoQueryBase_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files != null && files.Any())
                    txtArquivoQueryBase.Text = files.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtArquivoQueryBase_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtArquivoQueryBase.Text = Corefunc.abrirDialogo();
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            txtPastaRequerente.Text = Corefunc.pastaDialogo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeR = txtNomeRotina.Text;
            string chamadoB = txtChamadoBase.Text;
            string nomeReq = txtNomeRequerente.Text;
            string periodoR = cmbQuandoRodar.Text;
            string observacoes = txtObservacoes.Text;
            string pastaReq = txtPastaRequerente.Text;
            string arquivoQueryB = txtArquivoQueryBase.Text;
            try
            {
                string queryB = Corefunc.lerQuery(arquivoQueryB, nomeR);
                if (periodoSelec && cmbQuandoRodar.SelectedItem.ToString() != "Diario")
                {
                    string quandoR = controleSelec.Text;
                    Rotina.criarRotina(nomeR, chamadoB, queryB, nomeReq, periodoR, observacoes, pastaReq, quandoR);
                }
                else
                {
                    Rotina.criarRotina(nomeR, chamadoB, queryB, nomeReq, periodoR, observacoes, pastaReq);
                }
                MessageBox.Show("Rotina criada com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbQuandoRodar_SelectedValueChanged(object sender, EventArgs e)
        {
            string opcao = cmbQuandoRodar.SelectedItem.ToString();
            if (periodoSelec && opcao != "Diario")
            {
                this.Controls.Remove(controleSelec);
                controleSelec = periodoDesc(opcao);
                this.Controls.Add(controleSelec);
            }
            else if (periodoSelec && opcao == "Diario")
            {
                this.Controls.Remove(controleSelec);
                periodoSelec = false;
            }
            else
            {
                periodoSelec = true;
                controleSelec = periodoDesc(opcao);
                this.Controls.Add(controleSelec);
            }
        }

        private void txtArquivoQueryBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPastaRequerente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeRequerente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtChamadoBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeRotina_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbQuandoRodar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
