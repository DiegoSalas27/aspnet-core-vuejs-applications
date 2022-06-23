using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Reflection;
using Travel.Application.Common.Interfaces;
using Travel.Domain.Entities;

namespace Travel.Data.Contexts
{
    public class TravelDbContext : DbContext, IApplicationDbContext
    {
        private readonly IDateTime _dateTime;
        private IDbContextTransaction _currentTransation;

        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

        public DbSet<TourList> TourLists { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }

        public TravelDbContext(DbContextOptions<TravelDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public async Task BeginTransactionAsync()
        {
            if (_currentTransation != null)
            {
                return;
            }

            _currentTransation = await base.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted).ConfigureAwait(false);
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await SaveChangesAsync().ConfigureAwait(false);

                _currentTransation.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransation != null)
                {
                    _currentTransation.Dispose();
                    _currentTransation = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransation?.Rollback();
            }
            finally
            {
                if (_currentTransation != null)
                {
                    _currentTransation.Dispose();
                    _currentTransation = null;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
