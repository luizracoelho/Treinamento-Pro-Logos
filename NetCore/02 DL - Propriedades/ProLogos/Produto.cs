using ProLogos.Base;
using System;

namespace ProLogos
{
    public class Produto : BaseDomain
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal SaldoEstoque { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
