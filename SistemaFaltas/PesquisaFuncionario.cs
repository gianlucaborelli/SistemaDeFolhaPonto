using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFaltas.Recursos;
using SistemaFaltas.Classes;

namespace SistemaFaltas
{
    public partial class PesquisaFuncionario : Form
    {
        private List<Funcionario> funcionarios = new();

        public PesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void PesquisaFuncionario_Load(object sender, EventArgs e)
        {
            LimpaPesquisa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaFuncionarios();
        }


        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (!Validacoes.ValidaCPF(txtCpf.Text))
            {
                NotificacaoPopUp.MostrarNotificacao("O C.P.F. informado é invalido", NotificacaoPopUp.AlertType.Warning);
                txtCpf.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadFuncionario frm = new();

            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.BringToFront();
            frm.Show();
        }

        private void LimpaPesquisa()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtMatricula.Clear();
            txtNome.Focus();
        }

        private void CarregaFuncionarios()
        {            
            bool status;

            funcionarios.Clear();
            
            if (chkAtivo.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            funcionarios = Funcionario.PesqueisaFuncionarios(txtNome.Text, txtCpf.Text, status);

            dgvResultadoPesquisa.DataSource = funcionarios;
            
            LimpaPesquisa();
        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CarregaFuncionarios();
            }
        }

        
        private void dgvResultadoPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Funcionario funcionarioSelecionado = funcionarios[dgvResultadoPesquisa.SelectedRows[0].Index];            

            CadFuncionario frm = new(funcionarioSelecionado);
            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.BringToFront();
            frm.Show();
        }
    }
}
