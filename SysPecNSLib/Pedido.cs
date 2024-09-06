using System;
using System.Collections.Generic;
using System.Linq;
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
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();

            return pedido;
        }

        public static List<Pedido> ObterLista(int idCliente=0)
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }
    }
}
