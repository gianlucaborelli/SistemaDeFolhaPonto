using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFaltas
{
    public partial class NotificacaoPopUp : Form
    {
        public NotificacaoPopUp(string mensagem, AlertType type)
        {
            InitializeComponent();       
            showAlert(mensagem, type);
        }

        public enum AlertType
        {
            Success, Info, Error, Warning
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        private int x, y;
        public void showAlert(string msg, AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                NotificacaoPopUp frm = (NotificacaoPopUp)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case AlertType.Success:
                    pbTipoNotificacao.Image = imageList1.Images[0];
                    this.BackColor = Color.FromArgb(34, 187, 51);
                    break;
                case AlertType.Info:
                    pbTipoNotificacao.Image = imageList1.Images[1];
                    this.BackColor = Color.FromArgb(91, 192, 222);
                    SystemSounds.Asterisk.Play();
                    break;
                case AlertType.Error:
                    pbTipoNotificacao.Image = imageList1.Images[2];
                    this.BackColor = Color.FromArgb(187, 33, 36);
                    break;
                case AlertType.Warning:
                    pbTipoNotificacao.Image = imageList1.Images[3];
                    this.BackColor = Color.FromArgb(240, 173, 78);
                    SystemSounds.Question.Play();
                    break;
            }


            this.lblmsg.Text = msg;
            this.TopMost = true;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        private NotificacaoPopUp.enmAction action;

        private void pbClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case NotificacaoPopUp.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = NotificacaoPopUp.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public static void MostrarNotificacao(string mensagem, AlertType type)
        {
            NotificacaoPopUp notificacaoPopUp = new(mensagem,type);
        }
    }
}
