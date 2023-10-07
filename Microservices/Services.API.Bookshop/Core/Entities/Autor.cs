using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.API.Bookshop.Core.Entities
{
    public class Autor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nombre")]
        public string Name { get; set; }
        [BsonElement("apellido")]
        public string LastName { get; set; }
        [BsonElement("gradocAcademico")]
        public string AcademicDegree { get; set; }
    }
}
