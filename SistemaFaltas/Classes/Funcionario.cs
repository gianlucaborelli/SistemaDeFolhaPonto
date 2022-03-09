using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SistemaFaltas.Recursos;
using System.Drawing;

namespace SistemaFaltas.Classes
{
    public class Funcionario
    {
        private Conexao exe = new();
        private Matricula matricula = new();

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public ulong Cpf { get; private set; }

        private string CaminhoDaFoto { get; set; }

        public bool Status { get; private set; }

        public Image Foto { get; private set; }

        private List<Matricula> listaDeMatricula = new List<Matricula>();

        public List<Matricula> ListaDeMatricula { get { return this.listaDeMatricula;} private set { } }

        public EstadoDoCadastro estadoDoCadastro { get; private set; }

        public Funcionario()
        {
            this.estadoDoCadastro = EstadoDoCadastro.Novo;
        }        

        public Funcionario(int id)
        {
            string cmdSqlFuncionario = "SELECT * FROM Funcionario WHERE (IdFuncionario LIKE '" + id + "')";

            DataTable tabelaFuncionario = exe.ExecutaQuery(cmdSqlFuncionario);

            if (tabelaFuncionario.Rows.Count == 1)
            {
                foreach (DataRow dr in tabelaFuncionario.Select())
                {
                    Id = int.Parse(dr["IdFuncionario"].ToString());
                    Nome = dr["Nome"].ToString();
                    Cpf = ulong.Parse(dr["Cpf"].ToString());
                    Status = bool.Parse(dr["Ativo"].ToString());
                    if (!string.IsNullOrWhiteSpace(dr["Foto"].ToString()))
                    {
                        CaminhoDaFoto = dr["Foto"].ToString();
                        Foto = Image.FromFile(CaminhoDaFoto);
                    }
                    estadoDoCadastro = EstadoDoCadastro.Selecionado;
                }
            }
            listaDeMatricula.AddRange(matricula.CarregaListaDeMatricula(id));
        }

        public enum EstadoDoCadastro
        {
            Novo, Selecionado, Editado
        }

        public static List<Funcionario> PesqueisaFuncionarios(string nome, string cpf, bool status)
        {
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            Conexao exe = new();

            string sql = "SELECT * FROM Funcionario Where 1=1 ";

            if (!string.IsNullOrWhiteSpace(nome) ||
                !string.IsNullOrWhiteSpace(Validacoes.TrataCpf(cpf)) ||
                !string.IsNullOrWhiteSpace(status.ToString()))
            {
                if (!string.IsNullOrWhiteSpace(nome))
                {
                    sql += " AND Nome like '" + nome + "'";
                }
                if (!string.IsNullOrWhiteSpace(Validacoes.TrataCpf(cpf)))
                {
                    sql += " AND Cpf like '" + Validacoes.TrataCpf(cpf) + "'";
                }
                if (!string.IsNullOrWhiteSpace(status.ToString()))
                {
                    sql += " AND Ativo like " + status.ToString();
                }
            }

            DataTable tabelaFuncionario = exe.ExecutaQuery(sql);

            foreach (DataRow dr in tabelaFuncionario.Select())
            {
                Funcionario funcionario = new();
                Matricula matricula = new();

                funcionario.Id = int.Parse(dr["IdFuncionario"].ToString());
                funcionario.Nome = dr["Nome"].ToString();
                funcionario.Cpf = ulong.Parse(dr["Cpf"].ToString());
                funcionario.Status = bool.Parse(dr["Ativo"].ToString());
                if (!string.IsNullOrWhiteSpace(dr["Foto"].ToString()))
                {
                    funcionario.CaminhoDaFoto = dr["Foto"].ToString();
                    funcionario.Foto = Image.FromFile(funcionario.CaminhoDaFoto);
                }                
                funcionario.estadoDoCadastro = EstadoDoCadastro.Selecionado;

                funcionario.listaDeMatricula.AddRange(matricula.CarregaListaDeMatricula(funcionario.Id));

                listaDeFuncionarios.Add(funcionario);
            }

            return listaDeFuncionarios;
        }

        public bool SalvaNovoFuncionario()
        {
            string sql = "INSERT INTO Funcionario (Nome, Cpf, Ativo, Foto) VALUES('"
                + this.Nome + "', '"
                + this.Cpf.ToString() + "', "
                + this.Status + ", '"
                + this.CaminhoDaFoto + "')";

            if (ValidaFuncionario())
            {
                try
                {
                    SalvaFoto();
                    this.Id = exe.QueryRetornaId(sql);
                    this.estadoDoCadastro = EstadoDoCadastro.Selecionado;

                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);

                    return true;
                }
                catch
                {
                    NotificacaoPopUp.MostrarNotificacao("Erro ao salvar Cadastro", NotificacaoPopUp.AlertType.Error);

                    return false;
                }
            }
            else
            {
                NotificacaoPopUp.MostrarNotificacao("Erro ao salvar Cadastro", NotificacaoPopUp.AlertType.Error);
                return false;
            }
        }


        public bool AtualizaFuncionario()
        {
            string sql = "UPDATE Funcionario SET Nome = '" + this.Nome +
                "', Cpf = '" + this.Cpf.ToString() +
                "', Ativo = " + this.Status +
                ", Foto = '" + this.CaminhoDaFoto +
                "'WHERE IdFuncionario = " + this.Id + "";
            try
            {
                if (ValidaFuncionario() && exe.ExecutaSql(sql))
                {
                    NotificacaoPopUp.MostrarNotificacao("Atualizado com sucesso", NotificacaoPopUp.AlertType.Success);
                    this.estadoDoCadastro = EstadoDoCadastro.Selecionado;

                    return true;
                }
                else
                {
                    NotificacaoPopUp.MostrarNotificacao("Erro ao atualizar Cadastro", NotificacaoPopUp.AlertType.Error);

                    return false;
                }
            }
            catch
            {
                NotificacaoPopUp.MostrarNotificacao("Erro ao atualizar Cadastro", NotificacaoPopUp.AlertType.Error);
                return false;
            }
        }

        protected bool DeletaFuncionario()
        {
            string cmdSqlFuncionario = "Delete FROM Funcionario WHERE (IdFuncionario LIKE '" + this.Id.ToString() + "')";
            string cmdSqlMatricula = "Delete * FROM Matricula WHERE (IdFuncionario LIKE '" + this.Id.ToString() + "')";


            if (ValidaStatus())
            {
                try
                {
                    exe.ExecutaSql(cmdSqlMatricula);
                    exe.ExecutaSql(cmdSqlFuncionario);

                    if (File.Exists(this.CaminhoDaFoto))
                    {
                        File.Delete(this.CaminhoDaFoto);
                    }

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool ValidaFuncionario()
        {
            if (string.IsNullOrEmpty(this.Nome))
            {
                //Não permitir cadastrar funcionário com nome em branco
                NotificacaoPopUp.MostrarNotificacao("Nome invalido", NotificacaoPopUp.AlertType.Error);
                return false;
            }
            else if (!Validacoes.ValidaCPF(this.Cpf.ToString()))
            {
                //Não permitir cadastrar funcionário com CPF invalido
                NotificacaoPopUp.MostrarNotificacao("C.P.F. invalido", NotificacaoPopUp.AlertType.Error);
                return false;
            }
            else if (ValidaStatus())
            {
                //Se o funcionário tiver matricula ativa, não permitir desativar o status do cadastro
                //Primeiro deverá ser feito a desativação das matriculas ativas
                NotificacaoPopUp.MostrarNotificacao("Funcionário com Matricula Ativa", NotificacaoPopUp.AlertType.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidaStatus()
        {
            bool resultado = false;

            foreach (Matricula mt in listaDeMatricula)
            {
                if (mt.Ativo == true)
                {
                    resultado = true;
                    break;
                }
                else
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        public void GravaNovaMatricula(Matricula matricula)
        {
            listaDeMatricula.Add(matricula.CarregaMatricula(matricula.GravaNovaMatricula(matricula)));
        }

        public void AtualizaMatricula(int indice)
        {

        }

        public bool InformaStatus(bool status)
        {
            
            if (estadoDoCadastro == EstadoDoCadastro.Novo)
            {
                Status = status;
                return true;
            }
            else if (status == true)
            {
                Status = status;
                estadoDoCadastro = EstadoDoCadastro.Editado;
                return true;
            }
            else
            {
                if (ValidaStatus())
                {
                    Status = status;
                    estadoDoCadastro = EstadoDoCadastro.Editado;
                    return true;
                }
                else
                {
                    NotificacaoPopUp.MostrarNotificacao("Funcionário possui matriculas ativas", NotificacaoPopUp.AlertType.Warning);
                    return false;
                }
            }
        }

        public bool InformaNome(string nome)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                NotificacaoPopUp.MostrarNotificacao("Nome Invalido", NotificacaoPopUp.AlertType.Error);

                return false;
            }
            else
            {
                if (estadoDoCadastro == EstadoDoCadastro.Selecionado)
                {
                    Nome = nome;
                    estadoDoCadastro = EstadoDoCadastro.Editado;
                    return true;
                }
                else
                {
                    Nome = nome;
                    return true;
                }
            }
        }

        public bool InformaCpf(string CPF)
        {
            if (Recursos.Validacoes.ValidaCPF(CPF))
            {
                this.Cpf = ulong.Parse(Validacoes.TrataCpf(CPF));

                if (this.estadoDoCadastro == EstadoDoCadastro.Selecionado)
                {
                    this.estadoDoCadastro = EstadoDoCadastro.Editado;
                }

                return true;
            }
            else
            {
                NotificacaoPopUp.MostrarNotificacao("CPF Invalido", NotificacaoPopUp.AlertType.Error);
                return false;
            }
        }

        public void InformaFoto(Image imagem)
        {
            if (estadoDoCadastro == EstadoDoCadastro.Novo || !File.Exists(CaminhoDaFoto))
            {
                Foto = imagem; 

                if (estadoDoCadastro == EstadoDoCadastro.Selecionado || estadoDoCadastro == EstadoDoCadastro.Editado)
                {
                    SalvaFoto();
                }
            }
            else
            {
                if (MessageBox.Show("O funcionário já possui uma Foto.\nDeseja substituir?", "Foto Existente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Foto.Dispose(); //Elimina a foto existente da memoria, pois ao tentar exclui-la do disco dará erro de acesso não permitido

                    Foto = imagem;

                    SalvaFoto();
                }
            }
        }

        private bool SalvaFoto()
        {
            if (Foto != null)
            {
                try
                {
                    CaminhoDaFoto = "C:\\Nova pasta\\" + Cpf.ToString() + ".png";

                    if (File.Exists(CaminhoDaFoto))
                    {
                        File.Delete(CaminhoDaFoto);

                        Foto.Save(CaminhoDaFoto, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else
                    {
                        Foto.Save(CaminhoDaFoto, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    if (estadoDoCadastro != EstadoDoCadastro.Novo)
                    {
                        estadoDoCadastro = EstadoDoCadastro.Editado;
                        NotificacaoPopUp.MostrarNotificacao("Foto adicionada com sucesso", NotificacaoPopUp.AlertType.Success);
                    }
                    
                    return true;
                }
                catch
                {
                    NotificacaoPopUp.MostrarNotificacao("Erro ao Salvar Foto", NotificacaoPopUp.AlertType.Error);
                    CaminhoDaFoto = string.Empty;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
