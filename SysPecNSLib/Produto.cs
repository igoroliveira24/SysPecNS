﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Produto
    {
        

        public int Id { get; set; }
        public string? CodBar { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime? DataCad { get; set; }
        public Estoque Estoque { get; set; }

        public Produto() { Categoria = new(); }
        

        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto)
        {
            //metodo construtor para usar a stored procedure para inserir produto
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;         

        }

        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem)
        {
           
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            
        }

        public Produto(string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {           
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        public Produto(int id, string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem = null, DateTime? dataCad = null)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            
        }

        public Produto(int id, string? codBar, string? descricao, double valorUnit, string? unidadeVenda, Categoria categoria, double estoqueMinimo, double classeDesconto, byte[]? imagem, DateTime dataCad)
        {
            Id = id;
            CodBar = codBar;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBar);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        
        public static Produto ObterPorId(int id)
        {
            Produto produto = new();//Objeto da Classe Produto em lista recebe um metodo construtor vazio
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(
                        dr.GetInt32(5)
                        ),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9)

                    ) ;
            }

            cmd.Connection.Close();
            return produto;
        }

        public static Produto ObterPorId(string id)
        {
            Produto produto = new();//Objeto da Classe Produto em lista recebe um metodo construtor vazio
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where cod_barras = '{id}'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(
                        dr.GetInt32(5)
                        ),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9)

                    );
            }

            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterLista(string nome = "")
        {   
            List<Produto> produtos = new();//Objeto da Classe Lista de Produto em lista recebe um metodo construtor vazio
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "select * from produtos order by descricao";
            if (nome == "")
            {
                cmd.CommandText = "select * from produtos " +
                    "order by descricao limit 10;";
            }
            else
            {
                cmd.CommandText = $"select * from produtos" +
                    $"where descricao like '%{nome}% order by descricao limit 10';";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    dr.GetString(4),
                    Categoria.ObterPorId(
                        dr.GetInt32(5)
                        ),
                    dr.GetDouble(6),
                    dr.GetDouble(7),
                    null,
                    dr.GetDateTime(9)

                    ));
            }
            cmd.Connection.Close();
            return produtos;
        }

        

    }
}
//sp_produto_insert
//spcod_barras 
//spdescricao 
//spvalor_unit 
//spunidade_venda 
//spcategoria_id 
//spestoque_minimo 
//spclasse_desconto 