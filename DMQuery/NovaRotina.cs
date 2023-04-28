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
            string nomeR = txtNomeRotina.Text.Replace(" ", "_");
            string chamadoB = txtChamadoBase.Text;
            string nomeReq = txtNomeRequerente.Text;
            string observacoes = txtObservacoes.Text;
            string pastaReq = txtPastaRequerente.Text;
            string arquivoQueryB = txtArquivoQueryBase.Text;
            try
            {
                string queryB = Corefunc.lerQuery(arquivoQueryB, nomeR);
                Rotina.criarRotina(nomeR, chamadoB, queryB, nomeReq, observacoes, pastaReq);
                MessageBox.Show("Rotina criada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
