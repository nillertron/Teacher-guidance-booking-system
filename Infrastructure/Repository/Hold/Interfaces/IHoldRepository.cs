using System.Threading.Tasks;

namespace Infrastructure.Repository.Hold.Concretes
{
    interface IHoldRepository:IRepository<Model.Hold>
    {
        Task DummyMethod();
    }
}