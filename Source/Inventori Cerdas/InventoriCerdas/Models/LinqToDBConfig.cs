using LinqToDB;
using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace InventoriCerdas.Models
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class LinqToDBConfig : ILinqToDBSettings
    {
        public string ConnectionString { get; set; }

        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "InventoriCerdas";
        public string DefaultDataProvider => ProviderName.SqlServer;

        public LinqToDBConfig(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "InventoriCerdas", // base connection string name
                        ProviderName = ProviderName.MySql,
                        ConnectionString = ConnectionString
                    };
            }
        }
    }
}
