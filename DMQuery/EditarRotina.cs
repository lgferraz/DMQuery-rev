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
    public partial class EditarRotina : Form
    {
        private Corefunc corefunc = new Corefunc();
        public string nomeRotina { get; set; }
        private Rotina rotina;
        public Control controleSelec;
        public EditarRotina()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeR = txtNomeRotina.Text;
            string chamadoB = txtChamadoBase.Text;
            string nomeReq = txtNomeRequerente.Text;
            string periodoR = cmbQuandoRodar.Text;
            string observacoes = txtObservacoes.Text;
            string pastaReq = txtPastaRequerente.Text;
            string queryB = txtQuery.Text;
            try
            {
                
                if (corefunc.periodoSelec && cmbQuandoRodar.SelectedItem.ToString() != "Diario")
                {
                    string quandoR = controleSelec.Text;
                    Rotina.editarRotina(this.nomeRotina, nomeR, chamadoB, nomeReq, periodoR, observacoes, pastaReq, queryB, quandoR);
                }
                else
                {
                    Rotina.editarRotina(this.nomeRotina, nomeR, chamadoB, nomeReq, periodoR, observacoes, pastaReq, queryB);
                }
                MessageBox.Show("Rotina editada com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarRotina_Load(object sender, EventArgs e)
        {
            this.rotina = Rotina.lerRotina(nomeRotina);
            this.corefunc.periodoSelec = true;
            txtNomeRotina.Text = rotina.nome_rotina;
            txtChamadoBase.Text = rotina.chamado_base;
            txtNomeRequerente.Text = rotina.nome_requerente;
            cmbQuandoRodar.SelectedItem = rotina.periodo;
            if (rotina.periodo != "Diario") { corefunc.periodoDesc(this.rotina.periodo, this.controleSelec); }
            txtObservacoes.Text = rotina.observacoes;
            txtPastaRequerente.Text = rotina.pasta_requerente;
            txtQuery.Text = rotina.query_base;
        }

        private void cmbQuandoRodar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcao = cmbQuandoRodar.SelectedItem.ToString();
            if (corefunc.periodoSelec && opcao != "Diario")
            {
                this.Controls.Remove(controleSelec);
                controleSelec = corefunc.periodoDesc(opcao, this.cmbQuandoRodar);
                this.Controls.Add(controleSelec);
            }
            else if (corefunc.periodoSelec && opcao == "Diario")
            {
                this.Controls.Remove(controleSelec);
                corefunc.periodoSelec = false;
            }
            else
            {
                corefunc.periodoSelec = true;
                controleSelec =corefunc.periodoDesc(opcao, this.cmbQuandoRodar);
                this.Controls.Add(controleSelec);
            }
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            txtPastaRequerente.Text = Corefunc.pastaDialogo();
        }
    }
}
