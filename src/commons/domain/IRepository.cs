namespace FamilyBudget.Common;

public interface IRepository<TEntity> where TEntity : IAggregateRoot;