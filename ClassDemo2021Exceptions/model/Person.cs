using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Exceptions.model
{
    public class Person
    {
        private int _id;        // mellem 1000-99999
        private string _name;   // ikke null og mindst 4 tegn lang
        private int _phone;     // 8 cifre

        public Person():this(1000,"dummy", 11111111)
        {
        }

        public Person(int id, string name, int phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public int Id
        {
            get => _id;
            set
            {
                if (!(1000 <= value && value <= 99999))
                {
                    // ikke ifølge krav
                    throw new PersonException(this, $"id skal være mellem 1000 - 99999 men var {value}");
                    
                    // metoden stopper her
                }

                // hvis ok 
                _id = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value == null || value.Length < 4)
                {
                    throw new ArgumentException($"name skal være mindst 4 tegn langt men var {value}");
                }

                _name = value;
            }
        }

        public int Phone
        {
            get => _phone;
            set
            {
                if (value < 10000000 || 99999999 < value)
                {
                    throw new ArgumentException($"tlf skal være 8 cifre men var {value}");
                }

                _phone = value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Phone)}: {Phone}";
        }
    }
}
