using programaFuncionario.Funcionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace programaFuncionario.Conexao
{
    internal class conexao
    {
        private static SqlConnection conn;
        private string demo;

        public conexao() {
            try
            {
                demo = @"Server=JMALAUENE;Database=Funcionarios;user Id=sa;Password=12345678, Trusted_Connection=true";
                conn = new SqlConnection(demo);
                conn.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public ArrayList imprimirFuncionarios()
        {
            ArrayList funcionarios = new ArrayList();
            try
            {
                using (SqlConnection conn = new SqlConnection(demo))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM funcionarios", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int codigo = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                int diasTrabalhados = reader.GetInt32(2);
                                double salarioDiario = reader.GetDouble(3);
                                funcionarios.Add(new Funcionarios(codigo, nome, diasTrabalhados, salarioDiario));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return funcionarios;
        }


        public bool insert(Funcionarios funcionario)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(demo))
                {
                    con.Open();
                    string query = "INSERT INTO Funcionarios(codigo,nome, dias_Tra, saDiario,saMensal) VALUES (@codigo,@nome, @dias_Tra, @saDiario,@saMensal)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", funcionario.getCodigo());
                        cmd.Parameters.AddWithValue("@nome", funcionario.getNome());
                        cmd.Parameters.AddWithValue("@dias_Tra", funcionario.getDiasTrabalhados());
                        cmd.Parameters.AddWithValue("@saDiario", funcionario.getSalarioDiario());
                        cmd.Parameters.AddWithValue("@saMensal", funcionario.salarioMensal());
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool deletar(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Funcionarios WHERE codigo = @codigo";
            return cmd.ExecuteNonQuery() > 0;
        }




    }
}
