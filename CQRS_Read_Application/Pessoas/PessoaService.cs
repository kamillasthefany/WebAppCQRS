using CQRS_Read_Infra.Persistence.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRS_Read_Application.Pessoas
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository)
        {
            this.pessoaRepository = pessoaRepository;
        }
        public void Delete(int id)
        {
            pessoaRepository.Delete(id);
        }

        public Pessoa Find(int id)
        {
            return pessoaRepository.Find(id);
        }

        public IQueryable<Pessoa> GetAll()
        {
            return pessoaRepository.Get();
        }

        public IQueryable<Pessoa> GetByName(string nome)
        {
            return pessoaRepository.Get(c => c.Nome.ToUpper().Contains(nome.ToUpper()));
        }

        public void Insert(Pessoa pessoa)
        {
            pessoaRepository.Insert(pessoa);
        }

        public void Update(Pessoa pessoa)
        {
            pessoaRepository.Update(pessoa);
        }
    }
}
