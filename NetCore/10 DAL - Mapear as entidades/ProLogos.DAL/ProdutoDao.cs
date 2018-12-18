using Dommel;
using ProLogos.DAL.Base;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ProLogos.DAL
{
    public class ProdutoDao : BaseDao<Produto>
    {
        public IList<Produto> ListarPorMarca(long marcaId)
        {
            using (var db = new SqlConnection(ConnectionString))
                return db.Select<Produto>(x => x.MarcaId == marcaId).ToList();
        }
    }
}
