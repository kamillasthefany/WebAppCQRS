using CQRS_Read_Infra.Persistence.Pessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Read_Infra.Persistence
{
    public interface IContexto
    {
        IPessoaRepository Pessoa { get; set; }
    }
}
