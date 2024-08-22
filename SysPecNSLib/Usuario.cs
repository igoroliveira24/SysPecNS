using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using static Mysqlx.Notice.Warning.Types;

namespace SysPecNSLib
{
    public class Usuario
    {
        

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        {
            Nivel = new();//inicializando propriedade nivel como objeto de tipo nivel       
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel)//metodo construtor usado para inserir
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;           
        }

        public Usuario(string? nome, string? email, string? senha, Nivel nivel, bool ativo)//metodo construtor usado para verificar ativo
        {            
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? email, string? senha, Nivel nivel, bool ativo)//metodo construtor para alterar algum valor 
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }
        public static Usuario ObterPorID(int id)
        {
            Usuario usuario = new();//objeto usuario com tipo usuario = metodo construtor usuario
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id};";
            var dr = cmd.ExecuteReader(); 
            if (dr.Read()) // se o dr ler algo na tabela 
            {

                usuario = new(//objeto usuario tipo Usuario = metodo construtor usuario
                    dr.GetInt32(0),//o leitor lera o conteudo reservado na posição 0 como int32
                    dr.GetString(1),//o leitor lera o conteudo reservado na posição 1 como String
                    dr.GetString(2),//o leitor lera o conteudo reservado na posição 2 como String
                    dr.GetString(3),//o leitor lera o conteudo reservado na posição 3 como String
                    Nivel.ObterPorId(
                        dr.GetInt32(4)//o leitor lera o conteudo reservado na posição 4 como int32
                        ),
                    dr.GetBoolean(5)//o leitor lera o conteudo reservado na posição 5 como booleano
                    ) ;
            }
            return usuario;
        }
        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome limit 10;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())//enquanto o data reader ler na tabela 
            {
                lista.Add(//adiciona um objeto na listagem
                    new(//objeto de tipo usuario e de metodo usuario
                        dr.GetInt32(0),//o leitor lera o conteudo reservado na posição 0 como int32
                        dr.GetString(1),//o leitor lera o conteudo reservado na posição 1 como string
                        dr.GetString(2),//o leitor lera o conteudo reservado na posição 2 como string
                        dr.GetString(3),//o leitor lera o conteudo reservado na posição 3 como String
                        Nivel.ObterPorId(
                            dr.GetInt32(4)//o leitor lera o conteudo reservado na posição 4 como int32
                            ),
                        dr.GetBoolean(5)//o leitor lera o conteudo reservado na posição 5 como booleano
                        )
                    );
            }

            return lista;
        }
        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email}' and  senha = md5('{senha}')"; // md5 gera um hash de 32 caracteres/criptografia simples
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(//objeto usuario tipo Usuario = metodo construtor usuario
                    dr.GetInt32(0),//o leitor lera o conteudo reservado na posição 0 como int32
                    dr.GetString(1),//o leitor lera o conteudo reservado na posição 1 como String
                    dr.GetString(2),//o leitor lera o conteudo reservado na posição 2 como String
                    dr.GetString(3),//o leitor lera o conteudo reservado na posição 3 como String
                    Nivel.ObterPorId(
                        dr.GetInt32(4)//o leitor lera o conteudo reservado na posição 4 como int32
                        ),
                    dr.GetBoolean(5)//o leitor lera o conteudo reservado na posição 5 como booleano
                    );
            }
            return usuario;
        }
        public void Atualizar()
        {
            // usuario: nome,senha,nivel...

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }


        }
        public void Aquivar()
        {            

        }
        public void Restaurar()
        {

        }
            

    }
}
