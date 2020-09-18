using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
    public interface IHoldRepository:IRepository<Model.Hold>
    {
        Task<Model.Hold> GetHoldWithIncludes(int id);
    }
}