using ProLogos.Base;
using System;

namespace ProLogos
{
    public class Produto : BaseDomain
    {
        #region Properties
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal SaldoEstoque { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        #endregion

        #region Constructors
        protected Produto() { }

        public Produto(string codigo, string descricao, decimal saldoEstoque, decimal valorCompra, decimal valorVenda)
        {
            Codigo = codigo;
            Descricao = descricao;
            SaldoEstoque = saldoEstoque;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            DataCadastro = DateTime.Now;
        }

        public Produto(string codigo, string descricao, decimal saldoEstoque, decimal valorCompra, decimal valorVenda, bool ativo)
            : this(codigo, descricao, saldoEstoque, valorCompra, valorVenda)
        {
            Ativo = ativo;
        }
        #endregion
    }
}
