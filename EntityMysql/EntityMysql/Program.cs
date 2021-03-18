using EntityMysql.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer<EntityContexto>(null);
            using (EntityContexto context = new EntityContexto())
            {
                Contato tit = new Contato()
                {
                    Nome = "Tiago",
                    Email = "djhamo@gmail.com"
                };

                context.Contatos.Add(tit);
                context.SaveChanges();

            }

        }
    }
}
