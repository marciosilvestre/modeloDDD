using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntidade> where TEntidade : class
    {
        void Add(TEntidade entidade);
        TEntidade GetById(int id);
        IEnumerable<TEntidade> GetAll();
        void Update(TEntidade entidade);
        void Remove(TEntidade entidade);

        void Dispose();

    }
}
