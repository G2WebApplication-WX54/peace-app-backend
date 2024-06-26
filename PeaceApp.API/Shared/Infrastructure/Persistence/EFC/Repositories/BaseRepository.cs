using Microsoft.EntityFrameworkCore;
using PeaceApp.API.Shared.Domain.Repositories;
using PeaceApp.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace PeaceApp.API.Shared.Infrastructure.Persistence.EFC.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext Context;

    protected BaseRepository(AppDbContext context) => Context = context;

    public async Task AddAsync(TEntity entity) => await Context.Set<TEntity>().AddAsync(entity);

    public async Task<TEntity?> FindByIdAsync(int id)
    {
        var entity = await Context.Set<TEntity>().FindAsync(id);
        if(entity == null) throw new Exception($"Id:{id} doesn't exist");
        return entity;
    }

    public async Task<TEntity?> FindAll() => await Context.Set<TEntity>().FirstOrDefaultAsync();

    public void Update(TEntity entity) => Context.Set<TEntity>().Update(entity);

    public void Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);

    public async Task<IEnumerable<TEntity>> ListAsync() => await Context.Set<TEntity>().ToListAsync();
}