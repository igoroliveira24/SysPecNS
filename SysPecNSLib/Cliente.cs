using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using MySql.Data.Types;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.BC;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_nasc { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco>? Enderecos { get; set; }
        

        public Cliente() 
        {
            Id = 0;
        }
        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime data_nasc)
        {

            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            
            


        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime data_nasc, DateTime data_cad, bool ativo)
        {

            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public Cliente( string? nome, string? cpf, string? telefone, string? email, DateTime data_nasc, DateTime data_cad, bool ativo, List<Endereco> Endereco)
        {
            
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            Enderecos = Endereco;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime data_nasc, DateTime data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            

        }
        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email,DateTime data_nasc,DateTime data_cad,bool ativo, List<Endereco> Endereco)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
            Enderecos = Endereco;

        }
        
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", Data_nasc);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public static Cliente ObterporId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id ={id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)/*,
                    Endereco.ObterListaPorClientesPorId(dr.GetString(8))*/
                    ) ;
            }
            cmd.Connection.Close();
            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if(nome == "")
            {
                cmd.CommandText = "select * from clientes " +                  
                    "order by nome limit 10;";
            }
            else
            {
                cmd.CommandText = $"select * from clientes where nome like '%{nome}%' order by nome limit 10;";                   


            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add( 
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)/*,
                    Endereco.ObterListaPorClientesPorId(dr.GetString(8))*/
                    )
                 );
            }
            cmd.Connection.Close();
            return lista;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdata_nasc", Data_nasc);
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set Ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set Ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
