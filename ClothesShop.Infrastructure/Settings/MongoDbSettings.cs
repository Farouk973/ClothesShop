using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Infrastructure.Settings
{
   
    
        public class MongoDbSettings : IMongoDbSettings
        {
            public string Connection { get; set; } = null!;
            public string DatabaseName { get; set; } = null!;
        }

        public interface IMongoDbSettings
        {
            string Connection { get; set; }
            string DatabaseName { get; set; }
        }
    
}
