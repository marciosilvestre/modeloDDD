using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntidade> : IDisposable, IRepositoryBase<TEntidade> where TEntidade : class
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Add(TEntidade entidade)
        {
            Db.Set<TEntidade>().Add(entidade);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> GetAll()
        {
            return Db.Set<TEntidade>().ToList();
        }

        public TEntidade GetById(int id)
        {
            return Db.Set<TEntidade>().Find(id);
        }

        public void Remove(TEntidade entidade)
        {
            Db.Set<TEntidade>().Remove(entidade);
            Db.SaveChanges();
        }

        public void Update(TEntidade entidade)
        {
            Db.Entry(entidade).State = EntityState.Modified;
            Db.SaveChanges();

        }
    }
}
