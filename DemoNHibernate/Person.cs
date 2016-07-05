using System;
using System.Text;
using System.Collections.Generic;


namespace DemoNHibernate
{

    public class Person
    {
        public virtual  int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual int? Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", ID, Name, Age);
        }
    }
}
