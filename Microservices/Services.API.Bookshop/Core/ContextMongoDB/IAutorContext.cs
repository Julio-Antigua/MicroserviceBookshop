using MongoDB.Driver;
using Services.API.Bookshop.Core.Entities;

namespace Services.API.Bookshop.Core.ContextMongoDB
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
