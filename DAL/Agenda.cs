
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL
{
    public class Agenda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //atributo da classe, quer dizer que esse id corresponde a esse Bson
        public string Id { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}