using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;


namespace Repository
{
    public class EntityDatabaseTransaction : IDatabaseTransaction
    {
        private IDbContextTransaction _transaction;
        public EntityDatabaseTransaction(EIA_DEVContext context)
        {
            _transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }
    }
}
