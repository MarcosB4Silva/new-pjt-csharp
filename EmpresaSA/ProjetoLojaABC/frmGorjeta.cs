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
    public partial class frmGorjeta : Form
    {
        public frmGorjeta()
        {
            InitializeComponent();
            carregaFuncionario();
            codigoGorjeta();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void codigoGorjeta()
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select codConta+1 from tbConta order by codConta desc;";
                comm.CommandType = CommandType.Text;

                comm.Connection = Conexao.obterconexao();

                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                DR.Read();

                txtCodGorjeta.Text = Convert.ToString(DR.GetInt32(0));

                Conexao.fecharConexao();
            }
            catch (Exception)
            {
                txtCodGorjeta.Text = "1";
            }
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
                cbbFuncionario.Items.Add(DR.GetString(0));
            }
            Conexao.fecharConexao();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        public void calcular()
        {
            try
            {
                Double valor = Convert.ToDouble(txtValorConta.Text);
                if (cbbAvalia.SelectedIndex == 0)
                {
                    txtGorjeta.Text = Convert.ToString(valor * 0.1);
                    txtTotal.Text = Convert.ToString(valor + (valor * 0.1));
                }
                if (cbbAvalia.SelectedIndex == 1)
                {
                    txtGorjeta.Text = Convert.ToString(valor * 0.08);
                    txtTotal.Text = Convert.ToString(valor + (valor * 0.08));
                }
                if (cbbAvalia.SelectedIndex == 2)
                {
                    txtGorjeta.Text = Convert.ToString(valor * 0.05);
                    txtTotal.Text = Convert.ToString(valor + (valor * 0.05));
                }
                if (cbbAvalia.SelectedIndex == 3)
                {
                    txtGorjeta.Text = Convert.ToString(valor * 0.02);
                    txtTotal.Text = Convert.ToString(valor + (valor * 0.02));
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Favor preencher os campos!!!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        }

        private void cbbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoFuncionario(cbbFuncionario.Text);
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCodFunc.Text.Equals("")||txtGorjeta.Text.Equals("")||txtTotal.Text.Equals("")||txtValorConta.Text.Equals("")||cbbAvalia.SelectedIndex.Equals(-1)||cbbFuncionario.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor preencher os campos!!!","Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if(confirmar() == 1)
                {
                    MessageBox.Show("Confirmado com sucesso.", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    codigoGorjeta();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao confirmar", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        public int confirmar()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbConta(avaliacao,valorConta,valorGorjeta,valorTotal, codFunc) values(@avalia, @valorConta, @valorGorjeta, @valorTotal, @codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@avalia", MySqlDbType.VarChar, 100).Value = cbbAvalia.Text;
            comm.Parameters.Add("@valorConta", MySqlDbType.Decimal, 9).Value = txtValorConta.Text;
            comm.Parameters.Add("@valorGorjeta", MySqlDbType.Decimal, 9).Value = txtGorjeta.Text;
            comm.Parameters.Add("@valorTotal", MySqlDbType.Decimal, 9).Value = txtTotal.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.VarChar, 100).Value = txtCodFunc.Text;

            comm.Connection = Conexao.obterconexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txtCodFunc.Clear();
            txtGorjeta.Clear();
            txtTotal.Clear();
            txtValorConta.Clear();
            cbbAvalia.SelectedIndex = -1;
            cbbFuncionario.SelectedIndex = -1;
            txtCodFunc.Clear();

            cbbFuncionario.Focus();
        }
    }
}
