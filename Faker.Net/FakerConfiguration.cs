using System;
using System.Xml.Xsl;
using Faker.Net.Enums;

namespace Faker.Net
{
    public class FakerConfiguration
    {
        public DatabaseType DatabaseType { get; set; }
        public int Rows { get; set; }
        //public class MongoIdentityOptions
        //{
        //    public string ConnectionString { get; set; } = "mongodb://localhost/default";

        //    public string UsersCollection { get; set; } = "Users";

        //    public string RolesCollection { get; set; } = "Roles";

        //    public string MigrationCollection { get; set; } = "_Migrations";

        //    public SslSettings SslSettings { get; set; }

        //    public Action<ClusterBuilder> ClusterConfigurator { get; set; }
        //}
    }

}

