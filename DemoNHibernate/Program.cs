using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using NHibernate.Linq;

namespace DemoNHibernate
{
    class Program
    {
        private static Configuration myConfiguration;
        private static ISessionFactory mySessionFactory;
        private static ISession mySession;

        static void Main(string[] args)
        {
            myConfiguration = new Configuration();
            myConfiguration.LinqToHqlGeneratorsRegistry<ExtendedLinqtoHqlGeneratorsRegistry>();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            var lstPerson = mySession.Query<Person>().Where(a => a.Name.Trim() == "PhuongTM");
            foreach (var person in lstPerson)
            {
                Console.WriteLine(person.ToString());
            }

            mySession.Close();
            Console.ReadLine();
        }
    }
}
