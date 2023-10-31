using _2L1.Infrastructure.Data.Providers.MongoDB.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2L1.Infrastructure.Data.Providers.MongoDB
{
    public class Entity : IEntity
    {
        public ObjectId Id { get; set; }
        public DateTime CreatAt => Id.CreationTime;
    }
}
