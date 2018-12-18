using System.Collections.Generic;

namespace ProLogos.Interfaces
{
    public interface IBaseDao<T> where T : class, IBaseDomain
    {
        T Encontrar(long id);
        IList<T> Listar();
        long Inserir(T entidade);
        void Alterar(T entidade);
        void Remover(T entidade);
    }
}
