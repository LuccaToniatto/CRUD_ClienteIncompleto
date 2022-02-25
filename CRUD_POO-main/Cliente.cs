using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_Restaurante
{
    class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public string cidade { get; set; }
        public string email { get; set; }
        public string celular { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\programas\\CRUD_POO-main\\DbJogador.mdf;Integrated Security=True");

        public List<Cliente> listacliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente c = new Cliente();
                c.Id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.data = Convert.ToDateTime(dr["data"])
                c.cidade = dr["cidade"].ToString();
                c.email = dr["email"].ToString();
                c.celular = dr["celular"].ToString();
                li.Add(c);
            }
            return li;
        }

        public void Inserir(string nome, string cidade, string email, string celular,DateTime data)
        {
            string sql = "INSERT INTO Cliente(nome,cidade,email,celular) VALUES ('" + nome + "','"+data+ "','" + email + "','" + celular + "','" + cidade + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localiza(int Id)
        {
            string sql = "SELECT * FROM Cliente WHERE Id = '" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cidade = dr["cidade"].ToString();
                email = dr["email"].ToString();
                celular = dr["celular"].ToString();
            }
        }

        public void Atualizar(int Id, string nome, string cidade, string email, string celular, DateTime data)
        {
            string sql = "UPDATE Jogador SET nome='" + nome + "',data='" +data+ "',email='" + email + "',celular='" + celular + "',cidade='" + cidade + "' WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Exclui(int Id)
        {
            string sql = "DELETE FROM Jogador WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
