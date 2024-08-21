using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace SysPecNSLib
{
    public class Nivel
    {
        // atributos (campo)
       

        // propriedades
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
              

        //métodos construtores
        public Nivel() { }

        public Nivel(string nome, string sigla) // sobrecarga de métodos 
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel(int id, string nome, string sigla) // usado para consulta
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }



        //métodos (requisitos)
        /// <summary>
        /// Método para inserir registro de nível na base de dados 
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();//cmd conversa e representa cmd = mandos do banco de dados
            cmd.CommandType = System.Data.CommandType.Text;//cmd tipo string ou tipo texto
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";//cmd recebe a representação em texto para executa-lo como comando sql no banco de dados
            cmd.ExecuteNonQuery();//executa um comando sql contra a conexão e retorna os numeros de linhas afetadas 
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            //consulta no banco e retornar o Nível
            var cmd = Banco.Abrir();//cmd conversa e representa comandos do banco de dados
            cmd.CommandType = CommandType.Text;//cmd tipo string ou tipe texto
            cmd.CommandText = $"select * from niveis where id = {id};"; //cmd conversa com o banco de dados e faz o comando que esta em interpolação
            var dr = cmd.ExecuteReader(); // a variavel dr recebe a tabela que selecionamos com o comando acima
            while (dr.Read()) // enquanto o dr ler algo na tabela 
            {

                nivel.Id = dr.GetInt32(0);// nivel.id recebe o que o dr lê na casa 0 da tabela
                nivel.Nome = dr.GetString(1);// nivel.nome recebe o que o dr lê na casa 1 da tabela
                nivel.Sigla = dr.GetString(2);// nivel.sigla recebe o que o dr lê na casa 2 da tabela
            }

            return nivel;
        }

        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new List<Nivel>();
            //consulta para retornar a lista de niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0), 
                        dr.GetString(1), 
                        dr.GetString(2)
                        )
                    );
            }
            return lista;
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update niveis" + 
                $"set nome = '{Nome}', sigla = '{Sigla}' where id = {Id}";
            return cmd.ExecuteNonQuery() > 0 ? true : false;// neste caso return simula é um comando, "?" simula o se pegando o comando executado como true, ":" retorna falso 
            
                
            

           
        }
            
        public void ExcluirNivel(int id)
        {
            
        }
    }
}
