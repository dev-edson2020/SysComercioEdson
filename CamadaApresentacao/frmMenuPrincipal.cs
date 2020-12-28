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
            subMenuProdutos.Visible = true;
            btnProdutos.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            SubMenuFerramentas.Visible = false;
            SubMenuConsultas.Visible = false;


            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuFerramentas.Hide();
            SubMenuConsultas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnApresentacao_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnApresentacao_Click_1(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
        }
        private void btnCadastroProduto_Click_1(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmProduto prod = new frmProduto();
            prod.Show();
        }

        private void btnCategorias_Click_2(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmCategoria form = new frmCategoria();
            form.Show();
        }

        private void btnApresentacao_Click_2(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmApresentacao form = new frmApresentacao();
            form.Show();
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = true;
            btnVendas.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuProdutos.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnVendasProduto_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = false;
            subMenuVendas.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = false;
            subMenuVendas.Hide();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = true;
            btnCompras.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmEntrada entrada = new frmEntrada();
            entrada.Show();

            SubMenuCompras.Visible = false;
            SubMenuCompras.Hide();
        }

      
        private void frmMenuPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            if (subMenuProdutos.Visible || SubMenuCompras.Visible ||
                subMenuVendas.Visible || SubMenuSistema.Visible ||
                SubMenuConfiguracoes.Visible || SubMenuConsultas.Visible|| SubMenuFerramentas.Visible == true)
            {
                subMenuProdutos.Hide();
                subMenuVendas.Hide();
                SubMenuCompras.Hide();
                SubMenuSistema.Hide();
                SubMenuConfiguracoes.Hide();
                SubMenuConsultas.Hide();
                SubMenuFerramentas.Hide();

                btnProdutos.BackColor = Color.Transparent;
                btnVendas.BackColor = Color.Transparent;
                btnCompras.BackColor = Color.Transparent;
                btnSistema.BackColor = Color.Transparent;
                btnConfiguracoes.BackColor = Color.Transparent;
                btnConsultas.BackColor = Color.Transparent;
                btnFerramentas.BackColor = Color.Transparent;
            }
        }
        private void btnSistema_Click(object sender, EventArgs e)
        {
            SubMenuSistema.Visible = true;
            btnSistema.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuCompras.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnSairSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            SubMenuConfiguracoes.Visible = true;
            btnConfiguracoes.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuSistema.Hide();
            SubMenuCompras.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            SubMenuConfiguracoes.Visible = false;
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = true;
            btnConsultas.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            subMenuProdutos.Visible = false;
            SubMenuFerramentas.Visible = false;

            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            subMenuProdutos.Hide();
            SubMenuFerramentas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnProdutos.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;
        }
        private void btnVendaData_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = false;
        }

        private void btnCompraData_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = false;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
           // GestaoUsuario();
           // labelNome.Text = Nome.ToLower();
           // labelAcesso.Text = Acesso;
        }
        private void GestaoUsuario()
        {
            if (Acesso == "Administrador" || Acesso == "Gerente")
            {
                btnProdutos.Enabled = true;
                btnVendas.Enabled = true;
                btnCompras.Enabled = true;
                btnConfiguracoes.Enabled = true;
                btnSistema.Enabled = true;
                btnConsultas.Enabled = true;
            }
            else if(Acesso == "Vendedor")
            {
                btnProdutos.Enabled = true;
                btnVendas.Enabled = true;
                btnCompras.Enabled = false;
                btnConfiguracoes.Enabled = false;
                btnSistema.Enabled = true;
                btnConsultas.Enabled = true;
            }
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsairInferior_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {

            SubMenuFerramentas.Visible = true;
            btnFerramentas.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            subMenuProdutos.Visible = false;
            SubMenuConsultas.Visible = false;

            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            subMenuProdutos.Hide();
            SubMenuConsultas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnProdutos.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
        }

        private void btnBeckupBd_Click(object sender, EventArgs e)
        {
            SubMenuFerramentas.Visible = false;
            SubMenuFerramentas.Hide();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = false;
            SubMenuCompras.Hide();
            frmFornecedor fornec = new frmFornecedor();
            fornec.Show();
        }
    }
}
