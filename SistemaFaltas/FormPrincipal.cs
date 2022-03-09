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


namespace SistemaFaltas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            escondeSubMenu();
        }

        #region Metodos e Controles do Formularios

        //Adiciona Ações aos icones de Maximizar, Minimzar e Fechar no Formulário
        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Cria evento de arrastar o formulário principal
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Evento para abrir formulários filhos dentro de um painel
        private void AbrirFormulario(object FormFilho)
        {
            if (this.pnlConteudo.Controls.Count > 0)
                this.pnlConteudo.Controls.RemoveAt(0);
            Form ff = FormFilho as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.pnlConteudo.Controls.Add(ff);
            this.pnlConteudo.Tag = ff;
            ff.Show();
        }

        //Metodo para esconder sub menus
        private void escondeSubMenu()
        {
            pnlSubMenuCadastro.Visible = false;
           
        }

        //Metodo mostra Menu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escondeSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Eventos do Formulario
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuCadastro);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PesquisaFuncionario());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotificacaoPopUp.MostrarNotificacao("Teste Completo ajaj a j s s j s j a a j a j s  a j a j a j a j a j ", NotificacaoPopUp.AlertType.Info);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
    }
}
