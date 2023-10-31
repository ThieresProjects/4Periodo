using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2L1.Infrastructure.Data.Providers.MongoDB
{
    public class BsonCollectionAttribute
    {
        public string CollectionName { get;}
        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
