using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
            txtDescricao.Clear();
            txtDescricao.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastrarAnimal abrir = new frmCadastrarAnimal();
            abrir.Show();
            this.Hide();
        }
    }
}
