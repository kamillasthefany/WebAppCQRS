using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CQRS_Read_Infra.Persistence.Pessoa
{
    public class PessoaRepository : IPessoaRepository
    {
        private static List<Pessoa> listaPessoasMemory = new List<Pessoa>();

        public void Delete(Pessoa entity)
        {
            listaPessoasMemory.Remove(entity);
        }

        public void Delete(object id)
        {
            listaPessoasMemory.Remove(this.Find(id));
        }

        public Pessoa Find(object id)
        {
            return listaPessoasMemory.AsQueryable().FirstOrDefault(c => c.Id.Equals(id));
        }

        public IQueryable<Pessoa> Get(Expression<Func<Pessoa, bool>> predicate = null)
        {
            return predicate != null ?
                listaPessoasMemory.AsQueryable().Where(predicate)
                : listaPessoasMemory.AsQueryable();
        }

        public void Insert(Pessoa entity)
        {
            if (entity.Id == -1)
            {
                entity = new Pessoa(
                    listaPessoasMemory.Count + 1,
                    entity.TipoPessoa,
                    entity.Nome,
                    entity.Idade);

                listaPessoasMemory.Add(entity);
            }
        }

        public void Update(Pessoa entity)
        {
            var pessoa = this.Find(entity.Id);
            pessoa.TipoPessoa = entity.TipoPessoa;
            pessoa.Idade = entity.Idade;
            pessoa.Nome = entity.Nome;
        }
    }
}
