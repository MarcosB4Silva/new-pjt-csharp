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
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        //limpar
        public void limpar()
        {
            cbbTipo.Enabled = false;
            cbbTipo.SelectedIndex = -1;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            ltbPesquisa.Items.Clear();
        }

        //habilitar campos
        public void habilitarCampos()
        {
            cbbTipo.Enabled = true;
            txtDescricao.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            ltbPesquisa.Items.Clear();

            txtDescricao.Focus();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            cbbTipo.SelectedIndex = -1;
            cbbTipo.Enabled = false;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            cbbTipo.SelectedIndex = -1;
            cbbTipo.Enabled = false;
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
            txtDescricao.Enabled = false;
            txtDescricao.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastrarAnimal abrir = new frmCadastrarAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                if (rdbTipo.Checked)
                {
                    pesquisaTipo(cbbTipo.Text);
                }
                else
                {
                    MessageBox.Show("Favor inserir algo no campo descrição!", "Menssagen do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    pesquisaCodigo();
                }
                if (rdbNome.Checked)
                {
                    pesquisa(txtDescricao.Text);
                    if (ltbPesquisa.Items.Count == 0)
                    {
                        MessageBox.Show("Nenhum animal encontrado!", "Menssagen do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
               
                }
            }
        }

        //pesquisar por nome
        public void pesquisa(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbAnimais where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();


            ltbPesquisa.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisa.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }

        // Pessquisa por codigo
        public void pesquisaCodigo()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select nome from tbAnimais where idAnimal = @codigo;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@Codigo", MySqlDbType.VarChar, 100).Value = txtDescricao.Text;

                comm.Connection = Conexao.obterconexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();
                DR.Read();

                ltbPesquisa.Items.Clear();
                ltbPesquisa.Items.Add(DR.GetString(0));
            }
            catch (Exception)
            {
                MessageBox.Show("Erro animal não encontrado",
                   "Mensagem do sistema",
                   MessageBoxButtons.OK, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }




            Conexao.fecharConexao();
        }

        //Pesquisa por tipo
        public void pesquisaTipo(string tipo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbAnimais where tipo like '%" + tipo + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = tipo;

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();


            ltbPesquisa.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisa.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }

        private void ltbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisa.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um item.","Mensagem do sistema",MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            else
            {
                string nome = ltbPesquisa.SelectedItem.ToString();
                frmCadastrarAnimal abrir = new frmCadastrarAnimal(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
