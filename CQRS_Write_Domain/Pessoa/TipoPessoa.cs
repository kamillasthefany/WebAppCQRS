using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Write_Domain.Pessoa
{
    [Flags]
    public enum TipoPessoa
    {
        Comum, 
        Admin
    }
}
