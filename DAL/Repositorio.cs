using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DAL
{
    public class Repositorio
    {
        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get
            {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>();
            }
        }
        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://julia216049:685231@cluster0.ts92cte.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("appDesktop");
            _agenda = mongoDatabase.GetCollection<Agenda>("Agenda");
        }
    }
}
