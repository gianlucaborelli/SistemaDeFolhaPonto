namespace SistemaFaltas
{
    partial class NotificacaoPopUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificacaoPopUp));
            this.pbTipoNotificacao = new System.Windows.Forms.PictureBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTipoNotificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTipoNotificacao
            // 
            this.pbTipoNotificacao.Location = new System.Drawing.Point(19, 24);
            this.pbTipoNotificacao.Name = "pbTipoNotificacao";
            this.pbTipoNotificacao.Size = new System.Drawing.Size(50, 50);
            this.pbTipoNotificacao.TabIndex = 0;
            this.pbTipoNotificacao.TabStop = false;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmsg.Location = new System.Drawing.Point(84, 24);
            this.lblmsg.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(114, 23);
            this.lblmsg.TabIndex = 1;
            this.lblmsg.Text = "Mensagem";
            // 
            // pbClose
            // 
            this.pbClose.Image = global::SistemaFaltas.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(410, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 26);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Success.png");
            this.imageList1.Images.SetKeyName(1, "Information.png");
            this.imageList1.Images.SetKeyName(2, "Error.png");
            this.imageList1.Images.SetKeyName(3, "Warning.png");
            // 
            // NotificacaoPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(450, 100);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.pbTipoNotificacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificacaoPopUp";
            this.Text = "FormAlerta";
            ((System.ComponentModel.ISupportInitialize)(this.pbTipoNotificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTipoNotificacao;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}