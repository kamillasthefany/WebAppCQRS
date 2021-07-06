using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQRS_Read_Infra.Persistence.Pessoa;

namespace CQRS_Read_Application.Pessoas
{
    public interface IPessoaService : IApplicationService<Pessoa>
    {
        Pessoa Find(int id);
        IQueryable<Pessoa> GetByName(string nome);
        IQueryable<Pessoa> GetAll();
        void Insert(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(int id);
    }
}
