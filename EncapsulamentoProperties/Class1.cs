using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EncapsulamentoProperties
{
    public class Produto
    {
        //Declaração de variavéis privadas
        private string _nome;
        private double _preço;
        private int _quantidade;

        public Produto() { } //Construtor padrão

        //Construtor personalizado
        public Produto(string nome, double preço, int quantidade)
        {
            _nome = nome;
            _preço = preço;
            _quantidade = quantidade;
        }

        //GET e SET
        public string GetNome()
        {
            return _nome;
        }

        //Entrada de dados
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        // Retorno dos valores Preço do produto e Quantidade do produto 
        public double GetPreço()
        {
            return _preço;
        }
        public double GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque() //Vai definir o valor total do estoque
        {
            return _preço * _quantidade; 
        }
        public void AdicionarProduto(int quantidade) //Vai adicionar produtos no estoque
        { 
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) //Vai remover produtos do estoque
        {
            _quantidade -= quantidade; 
        }
        public override string ToString()
        {
            return _nome + ", R$ " + _preço.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
