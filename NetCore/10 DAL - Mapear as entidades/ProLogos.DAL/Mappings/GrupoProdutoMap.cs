using Dapper.FluentMap.Dommel.Mapping;

namespace ProLogos.DAL.Mappings
{
    public class GrupoProdutoMap : DommelEntityMap<GrupoProduto>
    {
        public GrupoProdutoMap()
        {
            ToTable("PRODUTOS");

            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Nome).ToColumn("NOME");
            Map(x => x.Descricao).ToColumn("DESCRICAO");
            Map(x => x.DataCadastro).ToColumn("DATA_CADASTRO");
        }
    }
}
