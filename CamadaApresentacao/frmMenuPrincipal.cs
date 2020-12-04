using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class frmMenuPrincipal : Form
    {
        public string IdFuncionario { get; internal set; }
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public string Acesso { get; internal set; }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmProduto prod = new frmProduto();
            prod.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCategoria categ = new frmCategoria();
            categ.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFuncionario func = new frmFuncionario();
            func.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedor fornec = new frmFornecedor();
            fornec.Show();
        }
    }
}
