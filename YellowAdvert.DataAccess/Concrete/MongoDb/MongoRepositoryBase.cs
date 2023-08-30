using MongoDB.Driver;
using System.Linq.Expressions;
using YellowAdvert.DataAccess.Abstract;
using YellowAdvert.Entities.Base;

namespace YellowAdvert.DataAccess.Concrete.MongoDb;

public class MongoRepositoryBase<T> : IEntityRepository<T>
    where T : ModelBase
{
    private readonly IMongoCollection<T> _collection;

    public MongoRepositoryBase(IMongoDatabase database, string collectionName)
    {
        _collection = database.GetCollection<T>(collectionName);
    }

    public async Task<List<T>> GetAll()
    {
        return await (await _collection.FindAsync(_ => true)).ToListAsync();
    }

    public async Task<List<T>> Get(Expression<Func<T, bool>> filter)
    {
        return await (await _collection.FindAsync(filter)).ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await (await _collection.FindAsync(Builders<T>.Filter.Eq("_id", id))).FirstOrDefaultAsync();
    }

    public async Task Add(T entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task Update(T entity)
    {
        var filter = Builders<T>.Filter.Eq("_id", await GetById(entity.Id));
        await _collection.ReplaceOneAsync(filter, entity);
    }

    public async Task Update(List<T> entities)
    {
        foreach (var entity in entities)
        {
            await Update(entity);
        }
    }

    public async Task PermanentDelete(Guid id)
    {
        var filter = Builders<T>.Filter.Eq("_id", await GetById(id));
        await _collection.DeleteOneAsync(filter);
    }

    public async Task SoftDelete(Guid id)
    {
        var filter = Builders<T>.Filter.Eq("_id", await GetById(id));
        var update = Builders<T>.Update.Set("IsDeleted", true);
        await _collection.UpdateOneAsync(filter, update);
    }
}
