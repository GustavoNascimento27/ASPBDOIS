
using MySql.Data.MySqlClient;
using Sextoapp.Models;
using Sextoapp.Repository.Contract;
using System.Data;

namespace Sextoapp.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string _conexaoMySQL;


        public ClienteRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

        public void Atualizar(Cliente cliente)
        {
            
            
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            string Situacao = SituacaoConstant.Ativo;

            using (var conexao = new MySqlConnection(_conexaoMySQL)) 
            { 
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("insert into Cliente(Nome, Nascimento, SExo, CPF, Telefone, Email, Senha, Situacao) " + " values (@Nome, @Nascimento, @Sexo, @CPF, @Celular, @Email, @Senha, @Situacao)", conexao); 
            }
            
            
            
            
            throw new NotImplementedException();
        }

        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }

        public Cliente Login(string Email, string Senha)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from cliente where Email = @Email and Senha = @Senha", conexao);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataReader dr;

                Cliente cliente = new Cliente();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    cliente.id = Convert.ToInt32(dr["Id"]);
                    cliente.Nome = Convert.ToString(dr["Nome"]);
                    cliente.Nascimento = Convert.ToDateTime(dr["Nascimento"]);
                    cliente.Sexo = Convert.ToString(dr["Sexo"]);
                    cliente.cpf = Convert.ToString(dr["cpf"]);
                    cliente.situacao = Convert.ToString(dr["situacao"]);
                    cliente.Celular = Convert.ToString(dr["Celular"]);
                    cliente.Email = Convert.ToString(dr["Email"]);
                    cliente.Senha = Convert.ToString(dr["Senha"]);

                }
                return cliente;
            }
        }

        public Cliente ObterCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodosClientes()
        {
            List<Cliente> cliList = new List<Cliente>();
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM CLIENTE", conexao);
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                DataTable dt = new DataTable();

                da.Fill(dt);

                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    cliList.Add(
                        new Cliente
                        {
                            id = Convert.ToInt32(dr["id"]),
                            Nome = (string)(dr["Nome"]),
                            Nascimento = Convert.ToDateTime(dr["Nascimento"]),
                            Sexo = Convert.ToString(dr["Sexo"]),
                            cpf = Convert.ToString(dr["CPF"]),
                            Celular = Convert.ToString(dr["Celular"]),
                            Email = Convert.ToString(dr["Email"]),
                            Senha = Convert.ToString(dr["Senha"]),
                            situacao = Convert.ToString(dr["Situacao"])
                        });
                }
                return cliList;


            }

            throw new NotImplementedException();
        }
    }
}
