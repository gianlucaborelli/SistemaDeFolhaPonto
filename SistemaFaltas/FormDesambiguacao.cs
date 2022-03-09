using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFaltas
{
    public partial class FormDesambiguacao : Form
    {

        //Formulário para filtrar pesquisas que retornarem mais de um resultado

        public DataTable dt;
        public string retorno { get; set; }

        public FormDesambiguacao()
        {
            InitializeComponent();
        }

        private void FormDesambiguacao_Load(object sender, EventArgs e)
        {
            dgvDesambiguacao.DataSource = dt;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtOk_Click(object sender, EventArgs e)
        {
            retorno = dgvDesambiguacao.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void dgvDesambiguacao_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvDesambiguacao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            retorno = dgvDesambiguacao.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
