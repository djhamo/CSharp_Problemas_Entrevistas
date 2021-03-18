using EntityMysql.Entidades;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


//using System.Data.Entity;

namespace EntityMysql
{
    public class EntityContexto : DbContext
    {
        public EntityContexto() 
            : base(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString)
        {
        }

        public DbSet<Contato> Contatos { get; set; }

    }


}
