using Dapper.FluentMap.Dommel.Mapping;

namespace ProLogos.DAL.Mappings
{
    public class MarcaMap : DommelEntityMap<Marca>
    {
        public MarcaMap()
        {
            ToTable("MARCAS");

            Map(x => x.Id).ToColumn("ID").IsKey();
            Map(x => x.Nome).ToColumn("NOME");
            Map(x => x.Segmento).ToColumn("SEGMENTO");
            Map(x => x.DataCadastro).ToColumn("DATA_CADASTRO");
        }
    }
}
