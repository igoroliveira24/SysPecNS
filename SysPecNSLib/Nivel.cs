using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nível = new();
            //consulta no banco e retornar o Nível
            return nível;
        }

        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            //consulta para retornar a lista de niveis
            return lista;
        }

        public bool Atualizar()
        {
            return true;
        }
            
        public void ExcluirNivel(int id)
        {
            
        }
    }
}
