using Dapper.FluentMap.Dommel.Mapping;

namespace ProLogos.DAL.Mappings
{
    public class ProdutoMap : DommelEntityMap<Produto>
    {
        public ProdutoMap()
        {
            ToTable("PRODUTOS");

            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Codigo).ToColumn("CODIGO");
            Map(x => x.Descricao).ToColumn("DESCRICAO");
            Map(x => x.SaldoEstoque).ToColumn("SALDO_ESTOQUE");
            Map(x => x.ValorCompra).ToColumn("VALOR_COMPRA");
            Map(x => x.ValorVenda).ToColumn("VALOR_VENDA");
            Map(x => x.DataCadastro).ToColumn("DATA_CADASTRO");
            Map(x => x.Ativo).ToColumn("ATIVO");
            Map(x => x.TipoProduto).ToColumn("TIPO_PRODUTO");
            Map(x => x.MarcaId).ToColumn("MARCA_ID");
            Map(x => x.GrupoProdutoId).ToColumn("GRUPO_PRODUTO_ID");
        }
    }
}
