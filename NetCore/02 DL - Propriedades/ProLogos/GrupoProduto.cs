using ProLogos.Base;
using System;

namespace ProLogos
{
    public class GrupoProduto : BaseDomain
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; private set; }
    }
}
