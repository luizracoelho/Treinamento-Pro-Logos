using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace ProLogos.DAL.Mappings.Register
{
    public class RegisterMappings
    {
        public static void Register() =>
           FluentMapper.Initialize(config =>
           {
               config.AddMap(new GrupoProdutoMap());
               config.AddMap(new MarcaMap());
               config.AddMap(new ProdutoMap());

               config.ForDommel();
           });
    }
}
