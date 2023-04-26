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
    public partial class Conectar : Form
    {
        public Conectar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conectar_Load(object sender, EventArgs e)
        {
            try
            {
                Configuracao config = Configuracao.lerConfig("Config.json");
                txtServidor.Text = config.servidor;
                txtLogin.Text = config.login;
                txtSenha.Text = config.senha;
                cmbMetodo.Text = config.metodo;
            }
            catch
            {
                //
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string metodo = cmbMetodo.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            Configuracao.salvarConfig(metodo, servidor, login, senha);
            try
            {
                Conexao.Conectar();
                Consulta consulta = new Consulta();
                consulta.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer conexão com servidor: \n" + ex.Message);
            }
        }
    }
}
