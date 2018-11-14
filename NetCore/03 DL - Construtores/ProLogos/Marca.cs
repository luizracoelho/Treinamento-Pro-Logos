using System;

namespace ProLogos
{
    public class Marca
    {
        #region Properties
        public string Nome { get; set; }
        public string Segmento { get; set; }
        public DateTime DataCadastro { get; private set; }
        #endregion

        #region Constructors
        protected Marca() { }

        public Marca(string nome, string segmento = null)
        {
            Nome = nome;
            Segmento = segmento;
            DataCadastro = DateTime.Now;
        }
        #endregion
    }
}
