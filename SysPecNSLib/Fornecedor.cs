using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {


        public int Id { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Fantasia { get; set; }
        public string? CNPJ { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public Produto? Produto_Id { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(Produto produto_Id, int id)
        {
            Produto_Id = produto_Id;
            Id = id;
        }

        public Fornecedor(string? razaoSocial, string? fantasia, string? cNPJ, string? contato, string? telefone, string? email)
        {

            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cNPJ;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(int id, string? razaoSocial, string? fantasia, string? cNPJ, string? contato, string? telefone, string? email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            CNPJ = cNPJ;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert into fornecedores (razao_social,fantasia,cnpj,contato,telefone,email) values ('{RazaoSocial}','{Fantasia}','{CNPJ}','{Contato}','{Telefone}','{Email}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Fornecedor ObterPorId(int id)
        {

            var cmd = Banco.Abrir();
            Fornecedor fornecedor = new();
            cmd.CommandText = $"select * from fornecedores where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            cmd.Connection.Close();
            return fornecedor;
        }

        public static List<Fornecedor> ObterLista()
        {

            var cmd = Banco.Abrir();
            List<Fornecedor> fornecedor = new();
            cmd.CommandText = $"select * from fornecedores";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    ));
            }
            cmd.Connection.Close();
            return fornecedor;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update fornecedores" +
                $"set razao_social = '{RazaoSocial}', fantasia = '{Fantasia}', cnpf = '{CNPJ}',contato = '{Contato}',telefone ='{Telefone}',email = '{Email}' where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void InserirpdtFornecedor()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert into produtofornecedor(produto_id, fornecedores_id) values('{Produto_Id}','{Id}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AtualizarpdtFornecedor()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update produtofornecedor " +
                $"set produto_id = '{Produto_Id}',fornecedores_id = '{Id}' where id = '{Id}'";

        }

        public static Fornecedor ObterPorIdFornecedor(int id)
        {

            var cmd = Banco.Abrir();
            Fornecedor fornecedor = new();
            cmd.CommandText = $"select * from produtofornecedor where fornecedores_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                    Produto.ObterPorId(dr.GetInt32(0)),
                    dr.GetInt32(1)
                    );
            }
            cmd.Connection.Close();
            return fornecedor;
        }

        public static List<Fornecedor> ObterListapdtFornecedor()
        {

            var cmd = Banco.Abrir();
            List<Fornecedor> fornecedor = new();
            cmd.CommandText = $"select * from produtofornecedor";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor.Add(new(
                    Produto.ObterPorId(dr.GetInt32(0)),
                    dr.GetInt32(1)
                    ));
            }
            cmd.Connection.Close();
            return fornecedor;

        }
    }
}
