using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno
{
    public class DalHelper : IDisposable
    {
       private static SqlConnection sqlConnection;
            public DalHelper()
            { }

            private static SqlConnection DbConnection()
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoSQL"].ConnectionString);
                sqlConnection.Open();
                return sqlConnection;
            }

            public static DataTable GetAlunos()
            {
                SqlDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Alunos";
                        da = new SqlDataAdapter(cmd.CommandText, DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                throw ex;
                }
            }

            public static DataTable GetAlunoTabela(int id)
            {
                SqlDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Alunos Where AlunoId=" + id;
                        da = new SqlDataAdapter(cmd.CommandText, DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Aluno GetAluno(int id)
            {
                SqlDataAdapter da = null;
                DataTable dt = new DataTable();
                Aluno aluno = new Aluno();
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Alunos Where AlunoId=" + id;
                        da = new SqlDataAdapter(cmd.CommandText, DbConnection());
                        da.Fill(dt);

                        aluno.AlunoId = Convert.ToInt32(dt.Rows[0]["AlunoId"]);
                        aluno.Nome = dt.Rows[0]["Nome"].ToString();
                        aluno.Endereco = dt.Rows[0]["Endereco"].ToString();
                        aluno.Email = dt.Rows[0]["Email"].ToString();
                        aluno.Telefone = dt.Rows[0]["Telefone"].ToString();
                        aluno.Status = dt.Rows[0]["Status"].ToString();
                        aluno.Turma = dt.Rows[0]["Turma"].ToString();

                        return aluno;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Add(Aluno aluno)
            {
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Alunos(Nome, Endereco,Email,Telefone,Status,Turma) values (@nome, @endereco, @email, @telefone, @Status, @Turma)";
                        cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                        cmd.Parameters.AddWithValue("@endereco", aluno.Endereco);
                        cmd.Parameters.AddWithValue("@email", aluno.Email);
                        cmd.Parameters.AddWithValue("@telefone", aluno.Telefone);
                        cmd.Parameters.AddWithValue("@Status", aluno.Status);
                        cmd.Parameters.AddWithValue("@Turma", aluno.Turma);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Update(Aluno aluno)
            {
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        if (aluno != null)
                        {
                            cmd.CommandText = "UPDATE Alunos SET Nome=@Nome,Email=@Email,Endereco=@Endereco,Telefone=@Telefone, Status=@Status, Turma=@Turma WHERE AlunoId=@Id";
                            cmd.Parameters.AddWithValue("@Id", aluno.AlunoId);
                            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
                            cmd.Parameters.AddWithValue("@Endereco", aluno.Endereco);
                            cmd.Parameters.AddWithValue("@Email", aluno.Email);
                            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
                            cmd.Parameters.AddWithValue("@Status", aluno.Status);
                            cmd.Parameters.AddWithValue("@Turma", aluno.Turma);
                            cmd.ExecuteNonQuery();
                        }
                    };
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Delete(int Id)
            {
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Alunos Where AlunoId=@Id";
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
     }
 
}

