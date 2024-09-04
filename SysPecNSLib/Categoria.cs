using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Categoria
    {
        

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria()
        {
          
        }
        public Categoria(string? nome, string? sigla)
        {
            
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string? nome)
        {
            Id = id;
            Nome = nome;
            
        }
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                categoria = new(dr.GetInt32(0), dr.GetString(1), null);
            }


            return categoria;
        }
        
        public static List<Categoria> ObterLista()//Objeto da classe Endereço em Lista
        {
            List<Categoria> categorias = new();//Objeto da Classe Endereço em lista recebe os metodos construtores de new 
            var cmd = Banco.Abrir();// variavel cmd recebe a ação de abrir o banco
            cmd.CommandText = "select * from categorias";//da um comando para selecionar tudo da tabela 
            var dr = cmd.ExecuteReader();//variavel dr recebe o que for lido 
            while (dr.Read())// enquanto for verdadeiro faça 
            {
                categorias.Add(new(dr.GetInt32(0), dr.GetString(1),null));//listagem em virtude dos metodos construtores
            }


            return categorias;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery();
        }

        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from categorias where id = {Id}";
            cmd.ExecuteNonQuery();
        }
    }
}
