using ProLogos.Base;
using System;

namespace ProLogos
{
    public class GrupoProduto : BaseDomain
    {
        #region Properties
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; private set; }
        #endregion

        #region Constructors
        protected GrupoProduto() { }

        public GrupoProduto(string nome, string descricao = null)
        {
            Nome = nome;
            Descricao = descricao;
            DataCadastro = DateTime.Now;
        }
        #endregion
    }
}
