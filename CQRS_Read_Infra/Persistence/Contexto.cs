using CQRS_Read_Infra.Persistence.Pessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Read_Infra.Persistence
{
    public class Contexto : IContexto
    {
        public IPessoaRepository Pessoa { get; set; }
        public Contexto(IPessoaRepository pessoaRepository)
        {
            this.Pessoa = pessoaRepository;
        }
       
    }
}
