using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace CQRS_Read_Infra.Persistence.Pessoa
{
    [Flags]
    public enum TipoPessoa
    {
        Comum,
        Admin
    }

    public class Pessoa
    {
        public int Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TipoPessoa TipoPessoa { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int id, TipoPessoa tipoPessoa, string nome, int idade)
        {

            if (string.IsNullOrEmpty(nome)) throw new ArgumentNullException("nome");

            this.Id = id;
            this.TipoPessoa = tipoPessoa;
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa(TipoPessoa tipoPessoa, string nome, int idade)
        {
            this.Id = -1;
            this.TipoPessoa = tipoPessoa;
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"{this.TipoPessoa}:[TipoPessoa]{this.TipoPessoa}, [Nome]{this.Nome}, [Idade], {this.Idade}";
        }
    }
}
