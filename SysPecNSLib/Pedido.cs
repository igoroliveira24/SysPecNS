using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Pedido
    {
        

        public int Id {get;set;}
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string? Estatus { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido()
        {

        }
        public Pedido(int id, string? estatus)
        {
            Id = id;
            Estatus = estatus;
        }
        public Pedido(Usuario usuario, Cliente cliente, DateTime data, string? estatus, double desconto)
        {
          
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Estatus = estatus;
            Desconto = desconto;
        }

        public Pedido(Usuario usuario, Cliente cliente,double desconto)
        {
            
            Usuario = usuario;
            Cliente = cliente;            
            Desconto = desconto;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string? estatus, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Estatus = estatus;
            Desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string? estatus, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Estatus = estatus;
            Desconto = desconto;
            Itens = itens;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);        
            cmd.Parameters.AddWithValue("spstatus", Estatus);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AlterarStatus()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set status = '{Estatus}' where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AtualizarDesconto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedidos set desconto = {Desconto} where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorID(
                        dr.GetInt32(1)
                        ),
                    Cliente.ObterporId(
                        dr.GetInt32(2)
                        ),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)
                    //Incluir Lista de Itens
                    ,ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    );
            }

            cmd.Connection.Close();
            return pedido;
        }


        /// <summary>
        /// Este metodo retorna uma lista de colunas da tabela pedidos do mysql
        /// </summary>
        /// <returns>Lista de todos os pedidos</returns>
        public static List<Pedido> ObterLista()
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                        dr.GetInt32(0),
                        Usuario.ObterPorID(
                            dr.GetInt32(1)
                            ),
                        Cliente.ObterporId(
                            dr.GetInt32(2)
                            ), 
                        dr.GetDateTime(3), 
                        dr.GetString(4), 
                        dr.GetDouble(5)
                        , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    )
                );
            }
            cmd.Connection.Close();
            return pedidos;
        }
        /// <summary>
        /// Este metodo retorna uma lista de colunas da tabela pedidos do mysql pelo id do cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lista de pedidos do cliente informado, caso haja.</returns>
        public static List<Pedido> ObterListaPorCliente(int id)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                        dr.GetInt32(0),
                        Usuario.ObterPorID(
                            dr.GetInt32(1)
                            ),
                        Cliente.ObterporId(
                            dr.GetInt32(2)
                            ),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5)
                        , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    )
                );
            }
            cmd.Connection.Close();
            return pedidos;
        }

        /// <summary>
        /// Este metodo retorna uma lista de colunas da tabela pedidos do mysql pelo id do usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Lista de pedidos do cliente informado, caso haja.</returns>
        public static List<Pedido> ObterListaPorUsuario(int id)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where usuario_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(
                    new(
                        dr.GetInt32(0),
                        Usuario.ObterPorID(
                            dr.GetInt32(1)
                            ),
                        Cliente.ObterporId(
                            dr.GetInt32(2)
                            ),
                        dr.GetDateTime(3),
                        dr.GetString(4),
                        dr.GetDouble(5)
                    )
                );
            }
            cmd.Connection.Close();
            return pedidos;
        }
    }
}

