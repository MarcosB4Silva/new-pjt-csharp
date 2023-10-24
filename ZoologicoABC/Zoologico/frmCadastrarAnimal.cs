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

        public frmCadastrarAnimal(string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
            pesquisarAnimal(nome);
            habilitarBtnsAlterar();
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
            cbbTipo.Enabled = false;
        }
        // Habilitar botões
        public void habilitarBtns()
        {
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            cbbTipo.Enabled = true;

            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        public void habilitarBtnsAlterar()
        {
            btnAlterar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCadastrar.Enabled = false;
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
            novocodigo();
        }

        //limpar campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        //limpar
        public void limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbbTipo.SelectedIndex = -1;
            txtIdade.Clear();
            habilitarBtns();

            txtNome.Focus();
            novocodigo();
        }

        //carregar codigo
        public void novocodigo()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select idAnimal+1 from tbAnimais order by idAnimal desc;";
                comm.CommandType = CommandType.Text;

                comm.Connection = Conexao.obterconexao();
                MySqlDataReader DR;
                DR = comm.ExecuteReader();
                DR.Read();

                txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            }
            catch (Exception)
            {
                txtCodigo.Text = "1";
            }

            Conexao.fecharConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text.Equals("") || txtNome.Text.Equals("") || cbbTipo.SelectedIndex == -1)
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
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return res;
        }

        public void pesquisarAnimal(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select* from tbAnimais where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            cbbTipo.Text = DR.GetString(2);
            txtIdade.Text = Convert.ToString(DR.GetInt32(3));

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisar abrir = new frmPesquisar();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Alterar(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                limpar();
                habilitarBtns();
            }
        }

        public int Alterar(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbAnimais set nome = @nome, tipo = @tipo, idade = @idade where idAnimal = @codigo;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbbTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = Convert.ToInt32(txtIdade.Text);
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return res;
        }

        //Excluir
        public int excluir(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbAnimais where idAnimal = @codigo;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return res;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?", "menssagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (resp == DialogResult.Yes)
            {
                if (excluir(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Animal excluido com sucesso", "menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpar();
                    habilitarBtns();
                    novocodigo();
                }
                else
                {
                    MessageBox.Show("ERRO! ao excluir", "menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
