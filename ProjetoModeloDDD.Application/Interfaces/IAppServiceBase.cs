using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IAppServiceBase<TEntidade> where TEntidade : class
    {
        void Add(TEntidade entidade);

        void Remove(TEntidade entidade);

        void Update(TEntidade entidade);

        IEnumerable<TEntidade> GetAll();

        TEntidade GetById(int id);

        void Dispose();
    }
}
