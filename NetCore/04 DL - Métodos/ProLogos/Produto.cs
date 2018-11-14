using ProLogos.Base;
using System;
using System.Text.RegularExpressions;

namespace ProLogos
{
    public class Produto : BaseDomain
    {
        #region Properties
        private string _codigo;
        public string Codigo { get => _codigo; set => SetCodigo(value); }

        private string _descricao;
        public string Descricao { get => _descricao; set => SetDescricao(value); }

        private decimal _saldoEstoque;
        public decimal SaldoEstoque { get => _saldoEstoque; set => SetSaldoEstoque(value); }

        private decimal _valorCompra;
        public decimal ValorCompra { get => _valorCompra; set => SetValorCompra(value); }

        private decimal _valorVenda;
        public decimal ValorVenda { get => _valorVenda; set => SetValorVenda(value); }

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

        #region Methods
        private void SetCodigo(string codigo)
        {
            var regex = new Regex("[a-zA-Z0-9]");

            if (string.IsNullOrEmpty(codigo))
                throw new ArgumentNullException(nameof(Codigo), "O campo código deve ser preenchido.");
            else if (codigo.Length > 15)
                throw new ArgumentOutOfRangeException(nameof(Codigo), "O campo código deve ter até 15 caracteres.");
            else if (!regex.IsMatch(codigo))
                throw new ArgumentException(nameof(Codigo), "O campo código deve conter apenas letras e números.");

            _codigo = codigo;
        }

        private void SetDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentNullException(nameof(Descricao), "O campo código deve ser preenchido.");
            else if (descricao.Length > 30)
                throw new ArgumentOutOfRangeException(nameof(Descricao), "O campo código deve ter até 30 caracteres.");

            _descricao = descricao;
        }

        private void SetSaldoEstoque(decimal saldoEstoque)
        {
            if (saldoEstoque < 0)
                throw new ArgumentOutOfRangeException(nameof(SaldoEstoque), "O campo saldo em estoque não pode ser negativo.");

            _saldoEstoque = saldoEstoque;
        }

        private void SetValorCompra(decimal valorCompra)
        {
            if (valorCompra < 0)
                throw new ArgumentOutOfRangeException(nameof(ValorCompra), "O campo valor de compra não pode ser negativo.");

            _valorCompra = valorCompra;
        }

        private void SetValorVenda(decimal valorVenda)
        {
            if (valorVenda < 0)
                throw new ArgumentOutOfRangeException(nameof(ValorVenda), "O campo valor de venda não pode ser negativo.");
            else if (valorVenda < ValorCompra)
                throw new ArgumentOutOfRangeException(nameof(ValorVenda), "O campo valor de venda não pode ser menor que o de compra.");

            _valorVenda = valorVenda;
        }
        #endregion
    }
}
