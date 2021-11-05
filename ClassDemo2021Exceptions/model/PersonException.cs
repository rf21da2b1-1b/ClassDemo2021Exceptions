using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Exceptions.model
{
    class PersonException:Exception
    {
        private Person _person;

        public Person Person => _person;

        public PersonException(Person p)
        {
            _person = p;
        }

        public PersonException(Person p, string message) : base(message)
        {
            _person = p;
        }
    }
}
