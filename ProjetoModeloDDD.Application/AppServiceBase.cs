using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntidade> : IDisposable, IServiceBase<TEntidade> where TEntidade : class
    {
        private readonly IServiceBase<TEntidade> _serviceBase;

        public AppServiceBase(IServiceBase<TEntidade> serviceBase)
        {
            _serviceBase = serviceBase;
        }


        public void Add(TEntidade entidade)
        {
            _serviceBase.Add(entidade);
        }
        
        public IEnumerable<TEntidade> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntidade GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntidade entidade)
        {
            _serviceBase.Remove(entidade);
        }

        public void Update(TEntidade entidade)
        {
            _serviceBase.Update(entidade);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
