using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceBase<TEntidade> : IDisposable, IServiceBase<TEntidade> where TEntidade : class
    {

        private readonly IRepositoryBase<TEntidade> _repository;

        public ServiceBase(IRepositoryBase<TEntidade> repository)
        {
            _repository = repository;
        }

        public void Add(TEntidade entidade)
        {
            _repository.Add(entidade);
        }
        
        public IEnumerable<TEntidade> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntidade GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntidade entidade)
        {
            _repository.Remove(entidade);
        }

        public void Update(TEntidade entidade)
        {
            _repository.Update(entidade);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
