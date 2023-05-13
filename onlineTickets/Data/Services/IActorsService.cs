using onlineTickets.Models;

namespace onlineTickets.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();

        Actor GetByID(int id);

        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
