using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Settings
{
   
    
        public class MongoDbSettings : IMongoDbSettings
        {
            public string ConnectionString { get; set; } = null!;
            public string DatabaseName { get; set; } = null!;
        }

        public interface IMongoDbSettings
        {
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
        }
    
}
