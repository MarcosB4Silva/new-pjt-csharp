using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zoologico
{
    public partial class frmCadastrarAnimal : Form
    {
        public frmCadastrarAnimal()
        {
            InitializeComponent();
            desabilitarBtns();
        }

        // desabilitar botões
        public void desabilitarBtns()
        {
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;

            txtNome.Enabled = false;
            txtIdade.Enabled = false;
            txtTipo.Enabled = false;
        }
        // Habilitar botões
        public void habilitarBtns()
        {
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnLimpar.Enabled = true;

            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtTipo.Enabled = true;

            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarBtns();
        }

        //limpar campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        //limpar
        public void limpar()
        {
            txtNome.Clear();
            txtTipo.Clear();
            txtIdade.Clear();

            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text.Equals("") || txtNome.Text.Equals("") || txtTipo.Text.Equals(""))
            {
                MessageBox.Show("ERROR!! favor prencher campos", "Menssagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (cadastrar() == 1)
                {
                    MessageBox.Show("Animal cadastrasdo", "Menssagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpar();
                }
                else
                {
                    MessageBox.Show("ERROR ao cadastrar o animal", "Menssagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
        //Cadastrar
        public int cadastrar()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAnimais (nome, tipo, idade) values (@nome, @tipo, @idade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = txtTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return res;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }
    }
}
