using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Services.API.Bookshop.Core.Entities;

namespace Services.API.Bookshop.Core.ContextMongoDB
{
    public class AutorContext : IAutorContext
    {
        private readonly IMongoDatabase _database;
        public AutorContext(IOptions<MongoSettings>options)
        {
            MongoClient client = new MongoClient(options.Value.ConnectionString);
            _database          = client.GetDatabase(options.Value.Datebase);
        }
        public IMongoCollection<Autor> Autores => _database.GetCollection<Autor>("Autor");
    }
}
