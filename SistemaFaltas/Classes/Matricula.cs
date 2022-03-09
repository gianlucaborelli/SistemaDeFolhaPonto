using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFaltas.Recursos;
using System.Data;

namespace SistemaFaltas.Classes
{
    public class Matricula
    {
        Conexao exe = new();

        public int IdMatricula { get; set; }
        public int IdFuncionario { get; set; }
        public int NumeroMatricula { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public bool Ativo { get; set; }
        public int CargaHoraria { get; set; }
        public int CargaSuplementar { get; set; }
        public int Htpc { get; set; }
        public int Htpi { get; set; }
        public int IdTipoContrato { get; set; }

        public Matricula()
        {

        }

        private Matricula(int idMatricula, int idFuncionario, int numeroMatricula, DateTime? dataInicio, DateTime? dataFim, bool ativo,
            int cargaHoraria, int cargaSuplementar, int htpc, int htpi, int idTipoContrato)
        {
            this.IdMatricula = idMatricula;
            this.IdFuncionario = idFuncionario;
            this.NumeroMatricula = numeroMatricula;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Ativo = ativo;
            this.CargaHoraria = cargaHoraria;
            this.CargaSuplementar = cargaSuplementar;
            this.Htpc = htpc;
            this.Htpi = htpi;
            this.IdTipoContrato = idTipoContrato;
        }

        public int GravaNovaMatricula(Matricula matricula)
        {
            int retorno = -1;

            string sql;
                        
            switch (string.IsNullOrEmpty(matricula.DataFim.ToString()), string.IsNullOrEmpty(matricula.DataInicio.ToString()))
            {
                case (true, true):
                    sql = "INSERT INTO Matricula " +
                    "(IdFuncionario, NumeroMatricula, Ativo, CargaHoraria, CargaSuplementar, HTPC, HTPI, IdTipoContrato) " +
                    "VALUES('"
                    + matricula.IdFuncionario.ToString() + "', '"
                    + matricula.NumeroMatricula.ToString() + "', "
                    + matricula.Ativo + ", '"
                    + matricula.CargaHoraria.ToString() + "', '"
                    + matricula.CargaSuplementar.ToString() + "', '"
                    + matricula.Htpc.ToString() + "', '"
                    + matricula.Htpi.ToString() + "', '"
                    + matricula.IdTipoContrato.ToString() + "')";
                    break;
                case (true, false):
                    sql = "INSERT INTO Matricula " +
                    "(IdFuncionario, NumeroMatricula, DataInicio, Ativo, CargaHoraria, CargaSuplementar, HTPC, HTPI, IdTipoContrato) " +
                    "VALUES('"
                    + matricula.IdFuncionario.ToString() + "', '"
                    + matricula.NumeroMatricula.ToString() + "', '"
                    + matricula.DataInicio.ToString() + "', "
                    + matricula.Ativo + ", '"
                    + matricula.CargaHoraria.ToString() + "', '"
                    + matricula.CargaSuplementar.ToString() + "', '"
                    + matricula.Htpc.ToString() + "', '"
                    + matricula.Htpi.ToString() + "', '"
                    + matricula.IdTipoContrato.ToString() + "')";
                    break;
                case (false, true):
                    sql = "INSERT INTO Matricula " +
                    "(IdFuncionario, NumeroMatricula, DataFim, Ativo, CargaHoraria, CargaSuplementar, HTPC, HTPI, IdTipoContrato) " +
                    "VALUES('"
                    + matricula.IdFuncionario.ToString() + "', '"
                    + matricula.NumeroMatricula.ToString() + "', '"
                    + matricula.DataFim.ToString() + "', "
                    + matricula.Ativo + ", '"
                    + matricula.CargaHoraria.ToString() + "', '"
                    + matricula.CargaSuplementar.ToString() + "', '"
                    + matricula.Htpc.ToString() + "', '"
                    + matricula.Htpi.ToString() + "', '"
                    + matricula.IdTipoContrato.ToString() + "')";
                    break;
                case (false, false):
                    sql = "INSERT INTO Matricula " +
                    "(IdFuncionario, NumeroMatricula, DataInicio, DataFim, Ativo, CargaHoraria, CargaSuplementar, HTPC, HTPI, IdTipoContrato) " +
                    "VALUES('"
                    + matricula.IdFuncionario.ToString() + "', '"
                    + matricula.NumeroMatricula.ToString() + "', '"
                    + matricula.DataInicio.ToString() + "', '"
                    + matricula.DataFim.ToString() + "', "
                    + matricula.Ativo + ", '"
                    + matricula.CargaHoraria.ToString() + "', '"
                    + matricula.CargaSuplementar.ToString() + "', '"
                    + matricula.Htpc.ToString() + "', '"
                    + matricula.Htpi.ToString() + "', '"
                    + matricula.IdTipoContrato.ToString() + "')";
                    break;
            }

            retorno = exe.QueryRetornaId(sql);

            if (retorno != -1)
            {
                return retorno;
            }
            else
            {
                return retorno;
            }
        }

        public List<Matricula> CarregaListaDeMatricula(int idFuncionario)
        {

            List<Matricula> listaDeMatricula = new();
            Matricula matricula;

            string cmdSqlMatricula = "SELECT * FROM Matricula WHERE (IdFuncionario LIKE '" + idFuncionario.ToString() + "')";

            DataTable tabelaMatricula = exe.ExecutaQuery(cmdSqlMatricula);

            if (tabelaMatricula.Rows.Count >= 1)
            {
                foreach (DataRow dr in tabelaMatricula.Select())
                {
                    matricula = new();

                    matricula.IdMatricula = int.Parse(dr["IdMatricula"].ToString());
                    matricula.IdFuncionario = int.Parse(dr["IdFuncionario"].ToString());
                    matricula.NumeroMatricula = int.Parse(dr["NumeroMatricula"].ToString());

                    if (!string.IsNullOrEmpty(dr["DataInicio"].ToString()))
                    {
                        matricula.DataInicio = DateTime.Parse(dr["DataInicio"].ToString());
                    }
                    
                    if (!string.IsNullOrEmpty(dr["DataFim"].ToString()))
                    {
                        matricula.DataFim = DateTime.Parse(dr["DataFim"].ToString());
                    }
                    

                    matricula.Ativo = bool.Parse(dr["Ativo"].ToString());
                    matricula.CargaHoraria = int.Parse(dr["CargaHoraria"].ToString());
                    matricula.CargaSuplementar = int.Parse(dr["CargaSuplementar"].ToString());
                    matricula.Htpi = int.Parse(dr["Htpi"].ToString());
                    matricula.Htpc = int.Parse(dr["Htpc"].ToString());
                    matricula.IdTipoContrato = int.Parse(dr["IdTipoContrato"].ToString());

                    listaDeMatricula.Add(matricula);
                }
            }
            return listaDeMatricula;
        }

        public Matricula CarregaMatricula(int idMatricula)
        {
            Matricula matricula = new();

            string cmdSqlMatricula = "SELECT * FROM Matricula WHERE (IdMatricula LIKE '" + idMatricula.ToString() + "')";

            DataTable tabelaMatricula = exe.ExecutaQuery(cmdSqlMatricula);

            if (tabelaMatricula.Rows.Count == 1)
            {
                foreach (DataRow dr in tabelaMatricula.Select())
                {
                    matricula.IdMatricula = int.Parse(dr["IdMatricula"].ToString());
                    matricula.IdFuncionario = int.Parse(dr["IdFuncionario"].ToString());
                    matricula.NumeroMatricula = int.Parse(dr["NumeroMatricula"].ToString());

                    if (string.IsNullOrEmpty(dr["DataInicio"].ToString()))
                    {
                        matricula.DataInicio = null;
                    }
                    else
                    {
                        matricula.DataInicio = DateTime.Parse(dr["DataInicio"].ToString());
                    }

                    if (string.IsNullOrEmpty(dr["DataFim"].ToString()))
                    {
                        matricula.DataFim = null;
                    }
                    else
                    {
                        matricula.DataFim = DateTime.Parse(dr["DataFim"].ToString());
                    }

                    matricula.Ativo = bool.Parse(dr["Ativo"].ToString());
                    matricula.CargaHoraria = int.Parse(dr["CargaHoraria"].ToString());
                    matricula.CargaSuplementar = int.Parse(dr["CargaSuplementar"].ToString());
                    matricula.Htpi = int.Parse(dr["Htpi"].ToString());
                    matricula.Htpc = int.Parse(dr["Htpc"].ToString());
                    matricula.IdTipoContrato = int.Parse(dr["IdTipoContrato"].ToString());
                }
            }
            return matricula;
        }

        public bool AtualizaMatricula()
        {
            return true;
        }
    }
}

