namespace SistemaFaltas
{
    partial class FormDesambiguacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCancelar = new System.Windows.Forms.Button();
            this.txtOk = new System.Windows.Forms.Button();
            this.dgvDesambiguacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesambiguacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCancelar
            // 
            this.txtCancelar.Location = new System.Drawing.Point(12, 283);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(75, 23);
            this.txtCancelar.TabIndex = 0;
            this.txtCancelar.Text = "Cancela";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOk
            // 
            this.txtOk.Location = new System.Drawing.Point(431, 283);
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(75, 23);
            this.txtOk.TabIndex = 1;
            this.txtOk.Text = "Confirma";
            this.txtOk.UseVisualStyleBackColor = true;
            this.txtOk.Click += new System.EventHandler(this.txtOk_Click);
            // 
            // dgvDesambiguacao
            // 
            this.dgvDesambiguacao.AllowUserToAddRows = false;
            this.dgvDesambiguacao.AllowUserToDeleteRows = false;
            this.dgvDesambiguacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesambiguacao.Location = new System.Drawing.Point(12, 89);
            this.dgvDesambiguacao.Name = "dgvDesambiguacao";
            this.dgvDesambiguacao.ReadOnly = true;
            this.dgvDesambiguacao.RowTemplate.Height = 25;
            this.dgvDesambiguacao.Size = new System.Drawing.Size(494, 182);
            this.dgvDesambiguacao.TabIndex = 2;
            this.dgvDesambiguacao.DoubleClick += new System.EventHandler(this.dgvDesambiguacao_DoubleClick);
            this.dgvDesambiguacao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDesambiguacao_MouseDoubleClick);
            // 
            // FormDesambiguacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 318);
            this.Controls.Add(this.dgvDesambiguacao);
            this.Controls.Add(this.txtOk);
            this.Controls.Add(this.txtCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDesambiguacao";
            this.Text = "FormDesambiguacao";
            this.Load += new System.EventHandler(this.FormDesambiguacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesambiguacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.Button txtOk;
        private System.Windows.Forms.DataGridView dgvDesambiguacao;
    }
}