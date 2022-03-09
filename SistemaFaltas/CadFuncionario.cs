using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFaltas.Classes;
using SistemaFaltas.Recursos.CapturaDeImagens;
using System.IO;
using SistemaFaltas.Recursos;

namespace SistemaFaltas
{
    public partial class CadFuncionario : Form
    {
        Funcionario funcionario;
        Matricula novaMatricula = new();
        BindingSource bSourceMatricula = new();
        FormCapturaDeImagem frm = new();


        //Controles referente a funcionário

        #region ControleDoFormulario

        public CadFuncionario()
        {
            InitializeComponent();
            funcionario = new();
            EstadoDeGravacaoFuncionario();
        }

        public CadFuncionario(Funcionario funcionarioSelecionado)
        {
            InitializeComponent();
                        

            LimpaDateTime(dataInicio);
            LimpaDateTime(dateFim);


            funcionario = funcionarioSelecionado;
            PreencheFormulario();
            EstadoDeGravacaoFuncionario();
        }

        private void EstadoDeGravacaoFuncionario()
        {
            switch (funcionario.estadoDoCadastro)
            {
                case Funcionario.EstadoDoCadastro.Novo:
                    btSalvar.Text = "Criar Novo";
                    btSalvar.Enabled = true;
                    tabPage2.Enabled = false;

                    break;
                case Funcionario.EstadoDoCadastro.Selecionado:
                    btSalvar.Text = "Salvar";
                    btSalvar.Enabled = false;
                    tabPage2.Enabled = true;

                    break;
                case Funcionario.EstadoDoCadastro.Editado:
                    btSalvar.Text = "Salvar";
                    btSalvar.Enabled = true;
                    tabPage2.Enabled = true;

                    break;                    
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CadFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (funcionario.estadoDoCadastro == Funcionario.EstadoDoCadastro.Editado)
            {
                if (MessageBox.Show("Existe alterações no cadastro do funcionário não Salvas.\n\nDeseja realmente sair?", "Deseja realmente sair?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.Dispose();
            }
        }
        private void PreencheFormulario()
        {
            txtNome.DataBindings.Add("Text", funcionario, "Nome");
            txtCPF.DataBindings.Add("Text", funcionario, "Cpf");

            if (funcionario.Status == true)
            {
                rbAtivo.Checked = true;
            }
            else
            {
                rbInativo.Checked = true;
            }

            if (funcionario.Foto != null)
            {
                pbFuncionario.Image = funcionario.Foto;                
            }

            CarregaGridViewMatricula();
        }

        private void CarregaGridViewMatricula()
        {
            bSourceMatricula.DataSource = funcionario.ListaDeMatricula;
            dgvListaMatriculas.DataSource = bSourceMatricula;

            dgvListaMatriculas.Columns["IdMatricula"].HeaderText = "ID";
            dgvListaMatriculas.Columns["IdMatricula"].Width = 40;

            dgvListaMatriculas.Columns["IdFuncionario"].Visible = false;

            dgvListaMatriculas.Columns["NumeroMatricula"].HeaderText = "N. Matricula";
            dgvListaMatriculas.Columns["NumeroMatricula"].Width = 100;

            dgvListaMatriculas.Columns["DataInicio"].HeaderText = "Início";
            dgvListaMatriculas.Columns["DataInicio"].Width = 100;
            dgvListaMatriculas.Columns["DataInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvListaMatriculas.Columns["DataFim"].HeaderText = "Fim";
            dgvListaMatriculas.Columns["DataFim"].Width = 100;
            dgvListaMatriculas.Columns["DataFim"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
                
        #endregion

        #region MetodosCadFuncionario        

        private bool AlteraStatus()
        {
            if (rbAtivo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region EventosCadFuncionario

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (funcionario.estadoDoCadastro == Funcionario.EstadoDoCadastro.Novo)
            {
                NotificacaoPopUp.MostrarNotificacao("Cadastre um novo Funcionário primeiro", NotificacaoPopUp.AlertType.Info);

                e.Cancel = true;
            }
        }

        private void btnNovaFoto_Click(object sender, EventArgs e)
        {
            if (frm.ShowDialog() == DialogResult.OK)
            {
                funcionario.InformaFoto(frm.image);
                pbFuncionario.Image = funcionario.Foto;
            }
            EstadoDeGravacaoFuncionario();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (funcionario.estadoDoCadastro == Funcionario.EstadoDoCadastro.Novo)
            {
                funcionario.SalvaNovoFuncionario();
                EstadoDeGravacaoFuncionario();
            }
            else
            {
                funcionario.AtualizaFuncionario();
                EstadoDeGravacaoFuncionario();
            }

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (funcionario.InformaNome(txtNome.Text))
            {
                txtNome.BackColor = Color.PaleGreen;
            }
            else
            {
                txtNome.Clear();
                txtNome.BackColor = Color.Salmon;
            }
            EstadoDeGravacaoFuncionario();
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (funcionario.InformaCpf(txtCPF.Text))
            {
                txtCPF.BackColor = Color.PaleGreen;
            }
            else
            {
                txtCPF.Clear();
                txtCPF.BackColor = Color.Salmon;
            }
            EstadoDeGravacaoFuncionario();
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            
        }
        #endregion

        //Controles referente a Matriculas


        string estadoMatricula = "";

        enum enumMatricula
        {
            Nova, Selecionada, Alterada, Finalizada
        }


        private void LimpaControlesMatricula()
        {
            txtCargaHoraria.Text = string.Empty;
            txtCargaSuplementar.Text = string.Empty;
            txtHTPC.Text = string.Empty;
            txtHTPI.Text = string.Empty;
            //boxCargo.SelectedIndex = 0;
            LimpaDateTime(dataInicio);
            LimpaDateTime(dateFim);
        }

        private void LimpaDateTime(DateTimePicker dateTime)
        {
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = " ";
        }

        private void SelecionaData(DateTimePicker dateTime)
        {
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd/MM/yyyy";
        }

        private void AlteraFormato_dataInicio(object sender, EventArgs e)
        {
            SelecionaData(dataInicio);

            if (estadoMatricula == enumMatricula.Nova.ToString())
            {
                novaMatricula.DataInicio = dataInicio.Value.Date;
            }
            else
            {   
                funcionario.ListaDeMatricula[0].DataInicio = dataInicio.Value.Date;
            }
        }

        private void AlteraFormato_dataFim(object sender, EventArgs e)
        {
            SelecionaData(dateFim);
            if (dateFim.Value >= dataInicio.Value)
            {
                if (estadoMatricula == enumMatricula.Nova.ToString())
                {
                    novaMatricula.DataFim = dateFim.Value.Date;
                }
                else
                {   
                    funcionario.ListaDeMatricula[0].DataFim = dateFim.Value.Date;
                }
            }
            else
            {
                NotificacaoPopUp.MostrarNotificacao("Data Final Invalida", NotificacaoPopUp.AlertType.Warning);
                LimpaDateTime(dateFim);
            }
        }

        private void btnEditarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                estadoMatricula = enumMatricula.Selecionada.ToString();
            }
            catch
            {

            }
        }

        private void SomenteNumeros_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                !(e.KeyCode == Keys.Back))
            {
                e.SuppressKeyPress = false;
            }
        }

        private void btnAddMatricula_Click(object sender, EventArgs e)
        {
            if (estadoMatricula.Equals(""))
            {
                // Grava Nova Matricula
            }
            else if (estadoMatricula.Equals(enumMatricula.Alterada.ToString()) || estadoMatricula.Equals(enumMatricula.Nova.ToString()))
            {
                // Atualiza Matricula
                if (estadoMatricula.Equals(enumMatricula.Nova.ToString()))
                {
                    funcionario.GravaNovaMatricula(novaMatricula);
                }
                else
                {
                    int indice = (int)dgvListaMatriculas.CurrentRow.Cells[0].Value;
                    funcionario.AtualizaMatricula(indice);
                }

                
            }
            else
            {   // Não há informações a ser Salva
                NotificacaoPopUp.MostrarNotificacao("Não existe alterações a ser Salva", NotificacaoPopUp.AlertType.Info);
            }
        }

        private void btnExcluirMatricula_Click(object sender, EventArgs e)
        {
            
        }

        private void rbStatus_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        private void rbSeleciona_MouseClick(object sender, MouseEventArgs e)
        {
            bool status;

            if (rbAtivo.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
                
            }

            funcionario.InformaStatus(status);

            EstadoDeGravacaoFuncionario();
        }
    }
}
