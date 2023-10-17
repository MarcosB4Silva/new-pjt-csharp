using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmCadastroUsuario : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastroUsuario()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        
        public frmCadastroUsuario(string nome)
        {
            carregarUsuarioPesquisar(nome);
            desabilitarCampos();
            txtNome.Text = nome;
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
        //desabilitar campos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnEcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        //desabilitar campos novo
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnEcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;


            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnEcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }
        //criado método de limpar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();

            txtNome.Focus();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if (cadastrarUsuarios(Convert.ToInt32(txtCodFunc.Text)) == 1)
                {
                    MessageBox.Show("Usuario cadastrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    desabilitarCamposNovo();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Senhas não conferem", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtSenha.Focus();
            }

        }
        // Carrega novo Codigo do Usuario  ******
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterconexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.fecharConexao();
        }
        // cadastro de usuario
        public int cadastrarUsuarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(usuario,senha,codFunc) values(@usuario,@senha,@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 30).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 30).Value = codFunc;

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();


            Conexao.fecharConexao();

            return res;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            carregaFuncionarios();
            habilitarCampos();
            carregaCodigo();
        }
        //Carregar Funcionario
        public void carregaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncSemUsu.Items.Clear();

            while (DR.Read())
            {
                lstFuncSemUsu.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }
        //carregar usuario
        public void carregarUsuario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.codUsu, usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = nome;

            comm.Connection = Conexao.obterconexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            try
            {
                txtRepetirSenha.Clear();
                txtCodigo.Text = DR.GetString(0);
                txtNome.Text = DR.GetString(1);
                txtSenha.Text = DR.GetString(2);

                txtCodFunc.Text = DR.GetInt32(3).ToString();
                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;
                Conexao.fecharConexao();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionario não possui cadastro", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                txtNome.Clear();
                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtCodFunc.Clear();
                txtNome.Focus();
                btnCadastrar.Enabled = true;
                btnAlterar.Enabled = false;

                // carregar codigo do funcionario
                carregaCodigo();// ****
                carregaCodigoFuncionarios(lstFuncSemUsu.SelectedItem.ToString());

            }

        }
        //carrega usuarios adicionais
        public void carregaCodigoFuncionarios(String nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterconexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodFunc.Text = Convert.ToString(DR.GetString(0));

            Conexao.fecharConexao();
        }

        private void lstFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncSemUsu.SelectedItem.ToString();
            carregarUsuario(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUsuarios(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Usuario alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            } else
            {
                MessageBox.Show("ERRO! ao alterar", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //alterar usuario
        public int alterarUsuarios(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update into tbUsuarios set usuario = @usuario, senha = @senha where codUso = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("@codUsu", MySqlDbType.VarChar, 10).Value = codigo;

            comm.Connection = Conexao.obterconexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            return res;
        }
    }
}
