using Flights.Model;

namespace Flights.Repository;

public interface Repository<ID, entityType> where entityType : Entity<ID>
{
    List<entityType> getAll();
    void add(entityType entity);
    void remove(entityType entity);
    entityType findById(ID id);

    //void update(entityType entitate, entityType nouaEntitate);
}