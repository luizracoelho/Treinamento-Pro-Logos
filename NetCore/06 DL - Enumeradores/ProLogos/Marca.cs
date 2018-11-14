using System;
using System.Collections.Generic;

namespace ProLogos
{
    public class Marca
    {
        #region Properties
        private string _nome;
        public string Nome { get => _nome; set => SetNome(value); }

        public string Segmento { get; set; }
        public DateTime DataCadastro { get; private set; }
        public virtual IList<Produto> Produtos { get; protected set; }
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

        #region Methods
        private void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException(nameof(Nome));
            else if (nome.Length > 30)
                throw new ArgumentOutOfRangeException(nameof(Nome), "O campo nome deve possuir até 30 caracteres");

            _nome = nome;
        }
        #endregion
    }
}
