using PastelariaDoZe.Dominio.Shared;
using System;

namespace PastelariaDoZe.Dominio.ProdutoModule
{
    public class Produto : EntidadeBase, IEquatable<Produto>
    {
        public string Nome { get; set; }
        public double ValorUnitario { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double valorUnitario, DateTime dataValidade, int quantidade)
        {
            this.Nome = nome;
            this.ValorUnitario = valorUnitario;
            this.DataValidade = dataValidade;
            this.Quantidade = quantidade;
        }

        public Produto()
        {

        }

        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "Digite o Nome do produto";

            if (DataValidade == DateTime.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data é obrigatório";

            if (DateTime.Now.Year - DataValidade.Year > 70)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data não aceita datas muito antigas";

            if (DataValidade < DateTime.Now)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data não aceita datas passadas";

            if (ValorUnitario <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Valor Unitário é obrigatório e maior que 0";

            if (Quantidade <= 0)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Quantidade está inválido";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Produto);
        }

        public bool Equals(Produto other)
        {
            return other != null
                && Id == other.Id
                && Nome == other.Nome
                && Quantidade == other.Quantidade
                && ValorUnitario == other.ValorUnitario
                && DataValidade == other.DataValidade;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, ValorUnitario, DataValidade, Quantidade);
        }
    }
}
