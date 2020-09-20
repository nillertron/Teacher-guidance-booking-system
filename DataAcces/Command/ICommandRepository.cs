using Model;
using System.Threading.Tasks;

namespace DataAcces.Command
{
    public interface ICommandRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Delete(T entity);
        Task Update(T entity);
    }
}