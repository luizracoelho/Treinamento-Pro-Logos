using ProLogos.Base;
using System;
using System.Collections.Generic;

namespace ProLogos
{
    public class GrupoProduto : BaseDomain
    {
        #region Properties
        private string _nome;
        public string Nome { get => _nome; set => SetNome(value); }

        private string _descricao;
        public string Descricao { get => _descricao; set => SetDescricao(value); }

        public DateTime DataCadastro { get; private set; }
        public virtual IList<Produto> Produtos { get; protected set; }
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

        #region Methods
        private void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentNullException(nameof(Nome));
            else if (nome.Length > 30)
                throw new ArgumentOutOfRangeException(nameof(Nome), "O campo nome deve possuir até 30 caracteres");

            _nome = nome;
        }

        private void SetDescricao(string descricao)
        {
            if (descricao?.Length > 140)
                throw new ArgumentOutOfRangeException(nameof(Descricao), "O campo descrição deve possuir até 140 caracteres");

            _descricao = descricao;
        }
        #endregion
    }
}
