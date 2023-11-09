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

namespace ProjetoLojaABC
{
    public partial class frmPesquisarGorjeta : Form
    {
        public frmPesquisarGorjeta()
        {
            InitializeComponent();
            carregaFuncionario();
            desativar();
        }

        public void desativar()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            dtpDia.Enabled = false;
            dtpFim.Enabled = false;
        }
        public void ativar()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            dtpDia.Enabled = true;
            dtpFim.Enabled = true;
        }

        public void carregaFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                cbbFuncionarios.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }

        public void codigoFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            txtCodFunc.Text = DR.GetString(0);
            Conexao.fecharConexao();
        }

        private void cbbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoFuncionario(cbbFuncionarios.Text);
            ativar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar(Convert.ToInt32(txtCodFunc.Text));
            if (ltbGorjeta.Items.Count == 0)
            {
                MessageBox.Show("Funcionários não possui gorjeta nesse dia","Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void pesquisar(int codigo)
        {
            Decimal total = 0;
            
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select valorGorjeta, avaliacao, CAST(data AS DATE)  from tbConta where codFunc = @codFunc and data between @Data and @data2";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 100).Value = codigo;
            comm.Parameters.Add("@Data", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDia.Text);
            comm.Parameters.Add("@Data2", MySqlDbType.Date).Value = Convert.ToDateTime(dtpFim.Text);

            comm.Connection = Conexao.obterconexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbGorjeta.Items.Clear();
            
            while (DR.Read())
            {
                ltbGorjeta.Items.Add("R$ " + DR.GetString(0) +" - "+ DR.GetString(1) + " " + DR.GetString(2));
                total = total + Convert.ToDecimal(DR.GetString(0));
            }
            txtTotal.Text = "R$ " + Convert.ToString(total);
            Conexao.fecharConexao();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            ltbGorjeta.Items.Clear();
            cbbFuncionarios.SelectedIndex = -1;
            txtCodFunc.Clear();
            txtTotal.Clear();
            dtpDia.Value = DateTime.Now;
            dtpFim.Value = DateTime.Now;
            desativar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGorjeta abrir = new frmGorjeta();
            abrir.Show();
            this.Hide();
        }
    }
}
