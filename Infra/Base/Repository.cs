using Domain.Base;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infra.Base
{
    public class Repository<TEntity> : IRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoClient _client;
        protected readonly IMongoCollection<TEntity> _collection;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new MongoClient(_configuration["MongoDBConnection:Server"]);
            _collection = _client.GetDatabase(_configuration["MongoDBConnection:DatabaseName"]).
                GetCollection<TEntity>(typeof(TEntity).Name);
        }


    }
}
